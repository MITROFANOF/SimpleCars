using UnityEngine;

[CreateAssetMenu(fileName = "New Gearbox", menuName = "Transmission Components/Gearbox", order = 2)]
public class Gearbox : ScriptableObject
{
    public float[] GearRatio;
    public float performance;


    public float CalcSpeed(float speed, int gear)
    {
        return speed / GearRatio[gear + 1];
    }
    public float CalcTorque(float torque, int gear)
    {
        return torque * Mathf.Abs(GearRatio[gear + 1]) * performance;
    }
}
