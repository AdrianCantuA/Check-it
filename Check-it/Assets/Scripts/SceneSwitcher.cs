using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    
    public void siguiente(){
        PlayerPrefs.SetInt("LlantaArreglada", 0);
        PlayerPrefs.SetInt("AceiteArreglado", 0);
        PlayerPrefs.SetInt("AnticongelanteArreglado", 0);
        PlayerPrefs.SetInt("BugWashArreglado", 0);
        PlayerPrefs.SetInt("Instrucciones", 0);
        SceneManager.LoadScene(2);
    }
    public void back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void inicio(){
        SceneManager.LoadScene(0);
    }
    public void login(){
        SceneManager.LoadScene(1);
    }
    public void tablero(){
        SceneManager.LoadScene(2);
    }
    public void carro(){
        SceneManager.LoadScene(3);
    }    
    public void motor(){
        SceneManager.LoadScene(4);
    }
    public void ProbarCarro(){
        SceneManager.LoadScene(5);
    }
   
}
