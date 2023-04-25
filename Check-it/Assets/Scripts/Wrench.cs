using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : MonoBehaviour
{
    public GameObject nutsObject;
    public float hoverRange = 1f;

    private bool isHovering = false;
    private Renderer nutsRenderer;

    void Start()
    {
        // Store the nuts object's renderer
        nutsRenderer = nutsObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if (isHovering)
        {
            // Make the nuts object appear on the floor if the wrench is hovering over it
            Vector2 floorPosition = new Vector2(nutsObject.transform.position.x - 2f, -3.7f); 
            nutsObject.transform.position = floorPosition;
        }
        
    }

  
/*
void OnMouseClick()
{
     Camera currentCamera = Camera.current;
        if (currentCamera == null)
        {
            currentCamera = Camera.main;
        }
}*/
void OnMouseDrag()
{
    
    // Get the position of the mouse in screen space
    Vector3 mousePos = Input.mousePosition;

    // Convert the mouse position to world space
    mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

    // Move the object to the mouse position
    transform.position = mousePos;
}


    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the wrench is hovering over the nuts object and set isHovering to true if it is
        if (other.gameObject == nutsObject)
        {
            float distance = Vector2.Distance(transform.position, nutsObject.transform.position);
            if (distance <= hoverRange)
            {
                isHovering = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Set isHovering to false when the wrench is no longer hovering over the nuts object
        if (other.gameObject == nutsObject)
        {
            isHovering = false;
        }
    }
}
