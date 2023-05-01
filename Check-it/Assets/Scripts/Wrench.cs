using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Wrench : MonoBehaviour
{
    public bool canRemoveTire = false;
    private bool isHovering = false;
    public GameObject Nut;
    private Renderer nutRenderer;
    public LlantaNueva LlantaNueva; 

    void Start()
    {
        nutRenderer = Nut.GetComponent<Renderer>();
    }

    void Update()
    {
        if (isHovering && LlantaNueva.ponerTornillos)
        {
            Vector2 Recolocacion = new Vector2(-4.31f, -2.61f); 
            Nut.transform.position = Recolocacion;
            PlayerPrefs.SetInt("LlantaArreglada", 1);
        }
        else if (isHovering)
        {
            Vector2 floorPosition = new Vector2(0f, -4f); 
            Nut.transform.position = floorPosition;
            canRemoveTire = true;
        }
                
    }

    void OnMouseDrag()
    {
        // Get the position of the mouse in screen space
        Vector3 mousePos = Input.mousePosition;

        // Convert the mouse position to world space
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

        // Move the wrench object to the mouse position
        transform.position = mousePos;

    }

    void OnTriggerEnter2D(Collider2D Nut)
    {
        isHovering = true;
    }

    void OnTriggerExit2D(Collider2D Nut)
    {
        isHovering = false;
    }
}
