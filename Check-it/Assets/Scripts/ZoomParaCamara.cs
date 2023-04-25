using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomParaCamara : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minFOV = 10f;
    public float maxFOV = 60f;

    void Update()
    {
        // Get the mouse wheel input
        float scrollWheelInput = Input.GetAxis("Mouse ScrollWheel");

        // Adjust the camera's field of view based on the input
        Camera camera = GetComponent<Camera>();
        float newFOV = camera.fieldOfView - scrollWheelInput * zoomSpeed;
        newFOV = Mathf.Clamp(newFOV, minFOV, maxFOV);
        camera.fieldOfView = newFOV;
    }
}


