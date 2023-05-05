using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float timer;
    public float score;

    public AudioSource audioSource;
    public AudioClip backgroundSound;

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

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundSound;
        audioSource.loop = true;
        audioSource.Play();
    }

    private void Update()
    {
        //only play if the current scene is not 1 or 2
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex > 1)
        {
            timer += Time.deltaTime;
        }
        else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            timer = 0;
            score = 0;
        }

        // start a timer for scene 5
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 5)
        {
            score += Time.deltaTime;

            // stop the background sound
            audioSource.Stop();
        }
    }
}

