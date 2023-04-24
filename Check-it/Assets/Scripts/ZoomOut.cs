using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondaryCamera;
    public Camera secondaryCamera2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainCamera.enabled = true;
            secondaryCamera.enabled = false;  
            secondaryCamera2.enabled = false;   
 
        }
    }
}
