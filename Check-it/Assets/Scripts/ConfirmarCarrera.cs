using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConfirmarCarrera : MonoBehaviour
{
    public Button buttonToShow;
    public Button buttonToHide1;
    public Button buttonToHide2;

    private void Start()
    {
        // Hide the buttons at start
        buttonToShow.gameObject.SetActive(true);
        buttonToHide1.gameObject.SetActive(false);
        buttonToHide2.gameObject.SetActive(false);

        // Add a listener to the button that will show the other buttons
        buttonToShow.onClick.AddListener(ShowOtherButtons);
    }

    private void ShowOtherButtons()
    {
        // Show the buttons that were previously hidden
        buttonToHide1.gameObject.SetActive(true);
        buttonToHide2.gameObject.SetActive(true);
    }
}


