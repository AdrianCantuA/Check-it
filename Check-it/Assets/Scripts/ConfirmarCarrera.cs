using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConfirmarCarrera : MonoBehaviour
{
    public GameObject dialog;
    public Button confirmButton;
    public Button cancelButton;

    void Start()
    {
        // Hide the dialog at start
        dialog.SetActive(false);

        // Add a listener to the confirm button
        confirmButton.onClick.AddListener(OnConfirmClicked);

        // Add a listener to the cancel button
        cancelButton.onClick.AddListener(OnCancelClicked);
    }

    void OnConfirmClicked()
    {
        // Start the game or perform the desired action
        Debug.Log("Starting the game...");
    }

    void OnCancelClicked()
    {
        // Hide the dialog
        dialog.SetActive(false);
    }

    public void ShowDialog()
    {
        // Show the dialog
        dialog.SetActive(true);
    }
}

