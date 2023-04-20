using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void siguiente(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void carro(){
        SceneManager.LoadScene(1);
    }
    public void llanta(){
        SceneManager.LoadScene(2);
    }
    public void gasolina(){
        SceneManager.LoadScene(3);
    }
    public void ventana(){
        SceneManager.LoadScene(4);
    }
    
}
