using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrucciones : MonoBehaviour
{
    public GameObject objectToDisable;

    void Update()
    {
        if ((PlayerPrefs.GetInt("Instrucciones", 0) == 0)){
            objectToDisable.SetActive(true);
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            objectToDisable.SetActive(false);
            PlayerPrefs.SetInt("Instrucciones", 1);
        }
        }
       
    }
}



