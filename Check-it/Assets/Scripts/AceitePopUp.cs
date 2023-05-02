using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AceitePopUp : MonoBehaviour
{ 
    public GameObject aceiteVacio;
    public GameObject aceiteLleno;
    public GameObject tapa;
    private bool isGameObjectVisible;

    void Start()
    {
        aceiteVacio.SetActive(false);
        aceiteLleno.SetActive(false);
        tapa.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (isGameObjectVisible)
            {
                HideGameObject();
            }
        }
    }

    public void OnButtonClick()
    {
        // Get the current value of the playerPref
        int gameObjectIndex = PlayerPrefs.GetInt("AceiteArreglado", 0);
        // Show the appropriate GameObject based on the playerPref value
        switch (gameObjectIndex)
        {
            case 0:
                ShowGameObject(tapa, aceiteVacio);
                break;
            case 1:
                ShowGameObject(tapa, aceiteLleno);
                break;
            default:
                HideGameObject();
                break;
        }
    }

    private void ShowGameObject(params GameObject[] gameObjectsToShow)
    {
        // Hide any currently visible GameObjects
        HideGameObject();

        // Show the specified GameObjects
        foreach (GameObject gameObjectToShow in gameObjectsToShow)
        {
            gameObjectToShow.SetActive(true);
        }

        isGameObjectVisible = true;
    }

    private void HideGameObject()
    {
        // Hide all three GameObjects
        aceiteVacio.SetActive(false);
        aceiteLleno.SetActive(false);
        tapa.SetActive(false);
        isGameObjectVisible = false;
    }
}
