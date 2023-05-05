using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CancelarConfirmarCarrera : MonoBehaviour
{
    public Button cancelar;
    public Button confirmar;

    private void Start()
    {
       
        // Add a listener to the button that will show the other buttons
        cancelar.onClick.AddListener(DesaparecerBotones);
        confirmar.onClick.AddListener(Confirmar);
    }

    private void DesaparecerBotones()
    {
        // Show the buttons that were previously hidden
        cancelar.gameObject.SetActive(false);
        confirmar.gameObject.SetActive(false);
    }
    private void Confirmar()
    {
        Debug.Log(PlayerPrefs.GetInt("ArreglarLlanta", 0));
        Debug.Log(PlayerPrefs.GetInt("ArreglarAceite", 0));
        Debug.Log(PlayerPrefs.GetInt("ArreglarAnticongelante", 0));
        Debug.Log(PlayerPrefs.GetInt("ArreglarBugWash", 0));
        SceneManager.LoadScene(5);
    }
}
