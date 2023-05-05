using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        // Update the timer text
        timerText.text = "Timer: " + gameManager.timer.ToString("F2");
    }
}
