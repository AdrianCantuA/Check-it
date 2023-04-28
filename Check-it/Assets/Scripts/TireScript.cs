using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TireScript : MonoBehaviour
{
    public GameObject nuts;
    private Vector3 tireStartPosition;
    public Wrench wrench;
    

    private void Start()
    {
        tireStartPosition = transform.position;
    }


    private void Update()
    {
        if (wrench.canRemoveTire && Input.GetKeyDown(KeyCode.R))
        {
            // Move the tire to a new position
            transform.position = new Vector3(10f, 0f, 0f);
            
            // Reset the tire position flag
            //canRemoveTire = false;
        }
    }
}
