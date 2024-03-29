using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TireScript : MonoBehaviour
{
    public GameObject nuts;
    private Vector3 tireStartPosition;
    public Wrench wrench;
    public bool tireRemoved = false;

    private void Start()
    {
        tireStartPosition = transform.position;
    }


    private void Update()
    {
        if ((wrench.canRemoveTire && Input.GetKeyDown(KeyCode.R)) || (PlayerPrefs.GetInt("LlantaArreglada", 0) >= 2))
        {
            // Move the tire to a new position
            transform.position = new Vector3(15f, 0f, 0f);
            tireRemoved = true;
            if (PlayerPrefs.GetInt("LlantaArreglada", 0) < 2)
            {
                PlayerPrefs.SetInt("LlantaArreglada", 2);
            }
        }
    }
}
