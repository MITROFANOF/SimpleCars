using System.Linq;
using UnityEngine;

namespace Scenes.Test.Transmission_Components.Scripts
{
	[CreateAssetMenu(fileName = "New Engine", menuName = "Transmission Components/Engine", order = 0)]
	public class Engine : ScriptableObject
	{
		private float _cutoffDps;
		public float CrankshaftSpeed { get; private set; }
		public AnimationCurve torqueCurve = new AnimationCurve(new Keyframe(0f, 100f), new Keyframe(10000f, 100f));

		public void Init()
		{
			_cutoffDps = torqueCurve.keys.Last().time * 6f;
		}

		public float CalcTorque(float currentRpm)
		{
			return torqueCurve.Evaluate(Mathf.Abs(currentRpm));
		}

		public void AccelerateInput(float value)
		{
			CrankshaftSpeed = _cutoffDps * value;
		}
	}
}
