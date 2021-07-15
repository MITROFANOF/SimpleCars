using Scenes.Test.Transmission_Components.Scripts;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Scenes.Test.Scripts
{
    public class Transmission : MonoBehaviour
    {
        public HingeJoint2D wheel;
        public Text info;
        [SerializeField] private Engine engine;
        [SerializeField] private Clutch clutch;
        [SerializeField] private Gearbox gearbox;
        [SerializeField] private TransferCase transferСase;
        [SerializeField] private Reducer reducer;
        private JointMotor2D _wheelMotor;
        [FormerlySerializedAs("wheelRB")] [SerializeField] private Rigidbody2D wheelRigidbody;
        private Rigidbody2D _car;
        private const float AirDensity = 1.225f;

        private float _wheelTorque, _wheelSpeed, _rpm;
        private int _gear;

        private InputMaster _controls;
        private float _accelerateValue, _clutchValue;

        private void Awake()
        {
            engine.Init();
            _car = GetComponentInParent<Rigidbody2D>();
            _controls = new InputMaster();
            _controls.Vehicle.Accelerate.performed += ctx => _accelerateValue = ctx.ReadValue<float>();
            _controls.Vehicle.Clutch.performed += ctx => _clutchValue = ctx.ReadValue<float>();
            _controls.Vehicle.GearUp.performed += ctx => GearUp();
            _controls.Vehicle.GearDown.performed += ctx => GearDown();
        }

        private void Update()
        {
            engine.AccelerateInput(_accelerateValue);
            //clutch.ClutchInput(clutchValue);
            _wheelMotor.maxMotorTorque = CalcTorque();
            _wheelMotor.motorSpeed = CalcSpeed();
            wheel.motor = _wheelMotor;
            _car.AddForce(AirDrag(_car.velocity, 0.3f, 2.5f));
            _car.AddForce(RoadDrag(_car.velocity, _car.mass, 0.029f));
            _rpm = -wheelRigidbody.angularVelocity / 6f * reducer.finalDrive * transferСase.finalDrive * gearbox.gearRatio[_gear + 1];
            info.text = $"Speed: {Mathf.Round(_car.velocity.magnitude * 3.6f)} km/h \nGear: {_gear}\nRPM: {_rpm}";
        }

        private float CalcTorque()
        {
            _wheelTorque = engine.CalcTorque(_rpm);
            _wheelTorque = clutch.CalcTorque(_wheelTorque);
            _wheelTorque = gearbox.CalcTorque(_wheelTorque, _gear);
            _wheelTorque = transferСase.CalcTorque(_wheelTorque);
            _wheelTorque = reducer.CalcTorque(_wheelTorque);
            return _wheelTorque;
        }

        private float CalcSpeed()
        {
            _wheelSpeed = engine.CrankshaftSpeed;
            _wheelSpeed = gearbox.CalcSpeed(_wheelSpeed, _gear);
            _wheelSpeed = transferСase.CalcSpeed(_wheelSpeed);
            _wheelSpeed = reducer.CalcSpeed(_wheelSpeed);
            return _wheelSpeed;
        }

        private void GearUp()
        {
            if (_gear >= gearbox.gearRatio.Length - 2) return;
            _gear++;
            StartCoroutine(clutch.GearSwitchDelay(0.065f));
        }

        private void GearDown()
        {
            if (_gear <= -1) return;
            _gear--;
            StartCoroutine(clutch.GearSwitchDelay(0.065f));
        }

        private Vector2 AirDrag(Vector2 velocity, float C, float S)
        {
            return -C * S * AirDensity  * velocity * new Vector2(Mathf.Abs(velocity.x), Mathf.Abs(velocity.y)) / 2f;
        }
        private Vector2 RoadDrag(Vector2 velocity, float mass, float C)
        {
            return velocity.normalized * (-C * mass * 9.81f);
        }


        private void OnEnable()
        {
            _controls.Enable();
        }
        private void OnDisable()
        {
            _controls.Disable();
        }


    }
}
