using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    public Camera tireCamera;
    public Camera mainCamera;
    

    private void Start()
    {
        // Disable the tire camera initially
        tireCamera.enabled = false;
    }

    public void OnClick()
    {
        // Disable the main camera
        mainCamera.enabled = false;

        // Enable the tire camera
        tireCamera.enabled = true;
    }
    

}
