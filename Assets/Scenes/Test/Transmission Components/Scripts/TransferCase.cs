using UnityEngine;

[CreateAssetMenu(fileName = "New TransferCase", menuName = "Transmission Components/TransferCase", order = 3)]
public class TransferCase : ScriptableObject
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