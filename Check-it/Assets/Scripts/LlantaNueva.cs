using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlantaNueva : MonoBehaviour

{
    private Vector3 tireStartPosition;
    public TireScript TireScript;
    public bool ponerTornillos = false;
    
    private void Start()
    {
        tireStartPosition = transform.position;
    }


    private void Update()
    {
        if (PlayerPrefs.GetInt("LlantaArreglada", 0))
        {
            transform.position = new Vector3(-4.25f, -2.78f, 0f);
            ponerTornillos = true;
        }

        else if (TireScript.tireRemoved && Input.GetKeyDown(KeyCode.T))
        {
            transform.position = new Vector3(-4.25f, -2.78f, 0f);
            ponerTornillos = true;
            
        }
    }
}


