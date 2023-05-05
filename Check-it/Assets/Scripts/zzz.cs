using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzz : MonoBehaviour
{
    private const string PlayerPrefName = "PlayerPreference";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerPrefs.SetInt(PlayerPrefName, 2);
            Debug.Log("PlayerPref set to 2");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt(PlayerPrefName, 1);
            Debug.Log("PlayerPref set to 1");
        }
    }
}
