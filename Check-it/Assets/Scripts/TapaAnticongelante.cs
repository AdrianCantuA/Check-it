using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapaAnticongelante : MonoBehaviour
{
    public Vector2 targetPosition = new Vector2(0, 0);
    public GameObject BotonAnticongelante;
    private Vector3 initialPosition;

    void Start()
    {
    BotonAnticongelante.SetActive(false);
    initialPosition = transform.position;
    }
    private void OnMouseDown()
    {
    if (PlayerPrefs.GetInt("AnticongelanteArreglado", 0) == 1)
    {
        transform.position = initialPosition;
        BotonAnticongelante.SetActive(false);
    }
    else 
    {
        Vector3 targetPos = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        transform.position = targetPos;
        BotonAnticongelante.SetActive(true);
    }   
    }
}

