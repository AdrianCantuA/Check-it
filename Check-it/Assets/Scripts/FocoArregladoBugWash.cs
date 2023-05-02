using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocoArregladoBugWash : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("BugWashArreglado") == 1)
        {
            // Set the game object to be inactive
            gameObject.SetActive(false);
        }
    }
}
