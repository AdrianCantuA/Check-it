using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocoArreglarAnticongelante : MonoBehaviour
{
   void Start()
    {
        if (PlayerPrefs.GetInt("AnticongelanteArreglado") == 1)
        {
            // Set the game object to be inactive
            gameObject.SetActive(false);
        }
    }
}
