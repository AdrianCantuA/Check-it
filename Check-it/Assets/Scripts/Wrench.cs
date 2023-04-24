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
            nutsObject.SetActive(false);
            nutsRenderer.material.color = Color.green;
        }
        else
        {
            // Make the nuts object disappear if the wrench is not hovering over it
            nutsObject.SetActive(true);
        }
    }

    void OnMouseDrag()
    {
        // Move the wrench object according to the mouse's position
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the wrench is hovering over the nuts object and set isHovering to true if it is
        if (other.gameObject == nutsObject)
        {
            isHovering = true;
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
