using System.Collections;
using UnityEngine;

namespace Scenes.Test.Transmission_Components.Scripts
{
	[CreateAssetMenu(fileName = "New Clutch", menuName = "Transmission Components/Clutch", order = 1)]
	public class Clutch : ScriptableObject
	{
		public float maxTorque;
		public float performance;
		private float _friction;

		public float CalcTorque(float torque)
		{
			torque *= _friction * performance;
			return torque < maxTorque ? torque : maxTorque;

			//Debug.Log("The clutch is slipping");
		}

		private void ClutchInput(float value)
		{
			_friction = 1 - value;
		}
		public IEnumerator GearSwitchDelay(float time)
		{
			ClutchInput(1f);
			yield return new WaitForSeconds(time);
			ClutchInput(0f);
		}
	}
}