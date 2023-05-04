using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugwash : MonoBehaviour
{
    // Reference to the button the object should touch
    public Transform targetButton;

    // The position and rotation where the object should be moved to
    public Vector3 targetPosition;
    public Quaternion targetRotation;

    // The time it takes to move the object to the target position
    public float moveTime = 2f;

    // Flag to indicate if the object is currently being dragged
    private bool isDragging = false;

    // The initial position of the object
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    public AudioClip oil; 
    private AudioSource audioSource;
    private bool hasPlayed = false;

    void Start()
    {
        // Store the initial position of the object
        initialPosition = transform.position;
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (isDragging)
        {
            // Get the current mouse position in world space
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Set the z-coordinate of the mouse position to the z-coordinate of the object
            mousePosition.z = transform.position.z;

            // Move the object to the mouse position
            transform.position = mousePosition;

            // Check if the object is touching the target button
            if (targetButton && targetButton.GetComponent<Collider2D>().OverlapPoint(transform.position))
            {
                // Move the object to the target position and rotation
                transform.position = targetPosition;
                transform.rotation = targetRotation;
                // Wait for the specified time
                StartCoroutine(WaitAndMoveBack(moveTime));	
                PlayerPrefs.SetInt("BugWashArreglado", 1);
            }
        }
    }

    void OnMouseDown()
    {
        // Set the flag to indicate that the object is being dragged
        isDragging = true;
    }

    void OnMouseUp()
    {
        // Set the flag to indicate that the object is no longer being dragged
        isDragging = false;
    }

    IEnumerator WaitAndMoveBack(float waitTime)
    {
        if (!hasPlayed)
        {
            audioSource.PlayOneShot(oil);
            hasPlayed = true;
        }
        // Wait for the specified time
        yield return new WaitForSeconds(waitTime);
        // Move the object back to its initial position
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}

