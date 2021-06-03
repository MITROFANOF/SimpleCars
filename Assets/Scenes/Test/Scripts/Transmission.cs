using UnityEngine;
using UnityEngine.UI;

public class Transmission : MonoBehaviour
{
    public HingeJoint2D wheel;
    public Text info;
    [SerializeField] private Engine engine;
    [SerializeField] private Clutch clutch;
    [SerializeField] private Gearbox gearbox;
    [SerializeField] private TransferCase transferСase;
    [SerializeField] private Reducer reducer;
    private JointMotor2D wheelMotor;
    [SerializeField] private Rigidbody2D wheelRB;
    private Rigidbody2D car;
    private readonly float airDensity = 1.225f;

    private float wheelTorque, wheelSpeed, rpm;
    private int gear;

    private InputMaster controls;
    private float accelerateValue, clutchValue;

    private void Awake()
    {
        engine.Init();
        car = GetComponentInParent<Rigidbody2D>();
        controls = new InputMaster();
        controls.Vehicle.Accelerate.performed += ctx => accelerateValue = ctx.ReadValue<float>();
        controls.Vehicle.Clutch.performed += ctx => clutchValue = ctx.ReadValue<float>();
        controls.Vehicle.GearUp.performed += ctx => GearUp();
        controls.Vehicle.GearDown.performed += ctx => GearDown();
    }

    private void FixedUpdate()
    {
        engine.AccelerateInput(accelerateValue);
        //clutch.ClutchInput(clutchValue);
        wheelMotor.maxMotorTorque = CalcTorque();
        wheelMotor.motorSpeed = CalcSpeed();
        wheel.motor = wheelMotor;
        car.AddForce(AirDrag(car.velocity, 0.3f, 2.5f));
        car.AddForce(RoadDrag(car.velocity, car.mass, 0.029f));
        rpm = -wheelRB.angularVelocity / 6f * reducer.finalDrive * transferСase.finalDrive * gearbox.GearRatio[gear + 1];
        info.text = $"Скорость: {Mathf.Round(car.velocity.magnitude * 3.6f)} км/ч \nПередача: {gear}\nRPM: {rpm}";
    }

    private float CalcTorque()
    {
        wheelTorque = engine.CalcTorque(rpm);
        wheelTorque = clutch.CalcTorque(wheelTorque);
        wheelTorque = gearbox.CalcTorque(wheelTorque, gear);
        wheelTorque = transferСase.CalcTorque(wheelTorque);
        wheelTorque = reducer.CalcTorque(wheelTorque);
        return wheelTorque;
    }

    private float CalcSpeed()
    {
        wheelSpeed = engine.CrankshaftSpeed;
        wheelSpeed = gearbox.CalcSpeed(wheelSpeed, gear);
        wheelSpeed = transferСase.CalcSpeed(wheelSpeed);
        wheelSpeed = reducer.CalcSpeed(wheelSpeed);
        return wheelSpeed;
    }

    private void GearUp()
    {
        if (gear < gearbox.GearRatio.Length - 2)
        {
            gear++;
            StartCoroutine(clutch.GearSwitchDelay(0.065f));
        }
    }

    private void GearDown()
    {
        if (gear > -1)
        {
            gear--;
            StartCoroutine(clutch.GearSwitchDelay(0.065f));
        }
    }

    private Vector2 AirDrag(Vector2 velocity, float C, float S)
    {
        return -C * S * airDensity  * velocity * new Vector2(Mathf.Abs(velocity.x), Mathf.Abs(velocity.y)) / 2f;
    }
    private Vector2 RoadDrag(Vector2 velocity, float mass, float C)
    {
        return -C * velocity.normalized * mass * 9.81f;
    }


    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }


}
