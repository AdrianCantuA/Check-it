using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcar : MonoBehaviour
{
    public Transform target; // La transformada del objeto a seguir
    public Vector3 offset; // La distancia entre la cámara y el objeto a seguir

    void LateUpdate()
    {
        transform.position = target.position + offset; // Establecer la posición de la cámara como la del objeto a seguir más un desplazamiento
    }
}
