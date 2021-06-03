using System;
using System.Collections;
using UnityEngine;

public class RaceLogic : MonoBehaviour
{
    public Rigidbody2D car;
    private float carSpeed;
    private bool measuring;

    private void FixedUpdate()
    {
        carSpeed = car.velocity.magnitude * 3.6f;
        if (!measuring && carSpeed > 3f)
        {
                StartCoroutine(Measuring());
                measuring = true;
        }
        if (measuring && carSpeed < 3f)
        {
            StopCoroutine(Measuring());
            measuring = false;
            Debug.Log("Готов к замеру");
        }
    }

    private IEnumerator Measuring()
    {
        Debug.Log("Начат замер");
        float timeStart = Time.time;
        while(carSpeed < 40f) yield return null;
        Debug.Log($"0-40 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 60f) yield return null;
        Debug.Log($"0-60 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 80f) yield return null;
        Debug.Log($"0-80 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 100f) yield return null;
        Debug.Log($"0-100 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 120f) yield return null;
        Debug.Log($"0-120 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 130f) yield return null;
        Debug.Log($"0-130 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 140f) yield return null;
        Debug.Log($"0-140 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 160f) yield return null;
        Debug.Log($"0-160 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 180f) yield return null;
        Debug.Log($"0-180 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 200f) yield return null;
        Debug.Log($"0-200 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 220f) yield return null;
        Debug.Log($"0-220 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 240f) yield return null;
        Debug.Log($"0-240 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 250f) yield return null;
        Debug.Log($"0-250 = {Math.Round(Time.time - timeStart, 1)}");
        while (carSpeed < 300f) yield return null;
        Debug.Log($"0-300 = {Math.Round(Time.time - timeStart, 1)}");

    }
    
}