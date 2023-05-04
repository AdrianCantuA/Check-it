using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float carVelocity;
    private AudioSource audioSource;
    public AudioClip Driving;
    public AudioClip StartEngine;
    public float engineVolume = 0.5f;
    public float drivingVolume = 1.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(StartEngine, engineVolume);
        audioSource.clip = Driving;
        audioSource.loop = true;
        audioSource.volume = drivingVolume;
        audioSource.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - carVelocity, transform.position.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + carVelocity, transform.position.y);
        }

        if(transform.position.x < -6.56f)
        {
            transform.position = new Vector2(-6.56f, transform.position.y);
        }
        else if(transform.position.x > 6.55f)
        {
            transform.position = new Vector2(6.55f, transform.position.y);
        }
        
    }
}