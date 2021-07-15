using UnityEngine;

namespace Scenes.Test.Transmission_Components.Scripts
{
    [CreateAssetMenu(fileName = "New Gearbox", menuName = "Transmission Components/Gearbox", order = 2)]
    public class Gearbox : ScriptableObject
    {
        public float[] gearRatio;
        public float performance;


        public float CalcSpeed(float speed, int gear)
        {
            return speed / gearRatio[gear + 1];
        }
        public float CalcTorque(float torque, int gear)
        {
            return torque * Mathf.Abs(gearRatio[gear + 1]) * performance;
        }
    }
}
