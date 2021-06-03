using System;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Engine", menuName = "Transmission Components/Engine", order = 0)]
public class Engine : ScriptableObject
{
	private float cutoffDPS;
	public float CrankshaftSpeed { get; set; }
	public AnimationCurve TorqueCurve = new AnimationCurve(new Keyframe(0f, 100f), new Keyframe(10000f, 100f));

	public void Init()
	{
		cutoffDPS = TorqueCurve.keys.Last().time * 6f;
	}

	public float CalcTorque(float currentRPM)
	{
		return TorqueCurve.Evaluate(Mathf.Abs(currentRPM));
	}

	public void AccelerateInput(float value)
	{
		CrankshaftSpeed = cutoffDPS * value;
	}
}
