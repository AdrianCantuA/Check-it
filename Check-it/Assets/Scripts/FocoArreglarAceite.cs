using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocoArreglarAceite : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("AceiteArreglado") == 1)
        {
            // Set the game object to be inactive
            gameObject.SetActive(false);
        }
    }
}
