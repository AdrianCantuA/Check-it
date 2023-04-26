using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class movement : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Mover hacia la izquierda si se presiona la flecha izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        // Mover hacia la derecha si se presiona la flecha derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
