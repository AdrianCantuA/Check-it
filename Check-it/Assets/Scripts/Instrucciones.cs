using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrucciones : MonoBehaviour
{
    public GameObject objectToDisable;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (objectToDisable != null)
            {
                objectToDisable.SetActive(false);
            }
        }
    }
}



