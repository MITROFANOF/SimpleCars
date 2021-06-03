using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clutch", menuName = "Transmission Components/Clutch", order = 1)]
public class Clutch : ScriptableObject
{
	public float maxTorque;
	public float performance;
	private float friction;

	public float CalcTorque(float torque)
	{
		torque *= friction * performance;
		if (torque < maxTorque)
		{
			return torque;
		}
		else
		{
			Debug.Log("Сцепление буксует");
			return Mathf.Clamp(torque, 0f, maxTorque);
		}
	}

	public void ClutchInput(float value)
	{
		friction = 1 - value;
	}
	public IEnumerator GearSwitchDelay(float time)
	{
		ClutchInput(1f);
		yield return new WaitForSeconds(time);
		ClutchInput(0f);
	}
}