using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pantalla : MonoBehaviour
{
    public InputField usernameInput;

    public void SetPlayerPreferenceOnClick()
    {
        string user = usernameInput.text;
        switch (user)
        {
            case "sebastiandash@icloud.com":
                PlayerPrefs.SetInt("PlayerPreference", 1);
                UnityEngine.Debug.Log("PlayerPref set to 1");
                break;
            case "karla@hotmail.com":
                PlayerPrefs.SetInt("PlayerPreference", 2);
                UnityEngine.Debug.Log("PlayerPref set to 2");
                break;
            case "pedrito@hotmail.com":
                PlayerPrefs.SetInt("PlayerPreference", 3);
                UnityEngine.Debug.Log("PlayerPref set to 3");
                break;
            case "jlopez@email.com":
                PlayerPrefs.SetInt("PlayerPreference", 4);
                UnityEngine.Debug.Log("PlayerPref set to 4");
                break;
            case "daniels@gmail.com":
                PlayerPrefs.SetInt("PlayerPreference", 5);
                UnityEngine.Debug.Log("PlayerPref set to 5");
                break;
            case "lpadilla@gmail.com":
                PlayerPrefs.SetInt("PlayerPreference", 6);
                UnityEngine.Debug.Log("PlayerPref set to 6");
                break;
            default:
                // If the user is not in the list, don't change the PlayerPref
                break;
        }
    }
}
