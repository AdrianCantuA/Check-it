using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapaBugwash : MonoBehaviour
{
    public Vector2 targetPosition = new Vector2(0, 0);
    public GameObject BotonBugwash;
    private Vector3 initialPosition;

    void Start()
    {
    BotonBugwash.SetActive(false);
    initialPosition = transform.position;
    }
    private void OnMouseDown()
    {
    if (PlayerPrefs.GetInt("BugWashArreglado", 0) == 1)
    {
        transform.position = initialPosition;
        BotonBugwash.SetActive(false);
    }
    else 
    {
        Vector3 targetPos = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        transform.position = targetPos;
        BotonBugwash.SetActive(true);
    }   
    }
}

