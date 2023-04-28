using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Wrench : MonoBehaviour
{
    public float hoverRange = 0.2f;
    public bool canRemoveTire = false;
    private bool isHovering = false;
    private Renderer nutsRenderer;
    private List<GameObject> nutsObjects = new List<GameObject>();
    
    void Start()
    {
        // Find all the nuts objects with the given tag and store their renderer
        GameObject[] nutsArray = GameObject.FindGameObjectsWithTag("Nut");
        foreach (GameObject nut in nutsArray)
        {
            nutsObjects.Add(nut);
        }
        nutsRenderer = nutsObjects[0].GetComponent<Renderer>();
    }

    void Update()
    {
        if (isHovering)
        {
            // Make all the nuts objects appear on the floor if the wrench is hovering over them
            foreach (GameObject nutObject in nutsObjects)
            {
                Vector2 floorPosition = new Vector2(nutObject.transform.position.x - 2f, -3.7f); 
                nutObject.transform.position = floorPosition;
                canRemoveTire = true;
            }
        }
        
    }

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
        // Add the entered object to the nutsObjects list if it has the tag "Nut"
        if (other.gameObject.CompareTag("Nut"))
        {
            nutsObjects.Add(other.gameObject);
            float distance = Vector2.Distance(transform.position, other.transform.position);
            if (distance <= hoverRange)
            {
                isHovering = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Remove the exited object from the nutsObjects list if it has the tag "Nut"
        if (other.gameObject.CompareTag("Nut"))
        {
            nutsObjects.Remove(other.gameObject);
            isHovering = false;
        }
    }
}
