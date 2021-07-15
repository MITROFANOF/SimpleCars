using UnityEngine;

namespace Scenes.Test.Transmission_Components.Scripts
{
    [CreateAssetMenu(fileName = "New Reducer", menuName = "Transmission Components/Reducer", order = 4)]
    public class Reducer : ScriptableObject
    {
        public float finalDrive;
        public float performance;

        public float CalcSpeed(float speed)
        {
            return speed / finalDrive;
        }
        public float CalcTorque(float torque)
        {
            return torque * finalDrive * performance;
        }
    }
}
