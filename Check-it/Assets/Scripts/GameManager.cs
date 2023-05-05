using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float timer;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        //only play if the current scene is not 1 or 2
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex > 1 || UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 5)
        {
        timer += Time.deltaTime;
        }
        else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            timer = 0;
        }
    }
}
