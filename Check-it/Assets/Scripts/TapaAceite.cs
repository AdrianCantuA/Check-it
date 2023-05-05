using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapaAceite : MonoBehaviour
{
    public Vector2 targetPosition = new Vector2(0, 0);
    public GameObject BotonAceite;
    private Vector3 initialPosition;

    void Start()
    {
    BotonAceite.SetActive(false);
    initialPosition = transform.position;
    }
    private void OnMouseDown()
    {
    if (PlayerPrefs.GetInt("AceiteArreglado", 0) == 1)
    {
        transform.position = initialPosition;
        BotonAceite.SetActive(false);
    }
    else 
    {
        Vector3 targetPos = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        transform.position = targetPos;
        BotonAceite.SetActive(true);
    }   
    }
}
