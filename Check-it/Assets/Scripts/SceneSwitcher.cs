using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void siguiente(){
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("LlantaArreglada", 0);
    }
    public void back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void carro(){
        SceneManager.LoadScene(1);
    }
    public void motor(){
        SceneManager.LoadScene(2);
    }
    public void tablero(){
        SceneManager.LoadScene(3);
    }
   
}
