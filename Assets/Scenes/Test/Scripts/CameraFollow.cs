using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private float distance;
    
    public float sensitivity = 1f;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, sensitivity / 50f);
        //distance = Vector3.Distance(transform.position, target.position + offset);
        //Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 3 + distance/5, sensitivity / 100f);
    }
}
