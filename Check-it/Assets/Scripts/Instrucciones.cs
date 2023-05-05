using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrucciones : MonoBehaviour
{
    public GameObject objectToDisable;
    void Start()
    {
        if (PlayerPrefs.GetInt("Instrucciones", 0) == 1)
        {
            objectToDisable.SetActive(false);
        }
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && PlayerPrefs.GetInt("Instrucciones", 0) == 0)
        {
            objectToDisable.SetActive(false);
            PlayerPrefs.SetInt("Instrucciones", 1);
        }
    }
}



