using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirMusica : MonoBehaviour
{
    // Public field for the object name
    public string objectName;

    void Start()
    {
        // Find the object using its name
        GameObject obj = GameObject.Find(objectName);

        // If the object is found, delete it
        if (obj != null) {
            Destroy(obj);
        }
    }
}


