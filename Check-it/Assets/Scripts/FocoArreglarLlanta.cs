using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocoArreglarLlanta : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("LlantaArreglada") == 4)
        {
            // Set the game object to be inactive
            gameObject.SetActive(false);
        }
    }
}
