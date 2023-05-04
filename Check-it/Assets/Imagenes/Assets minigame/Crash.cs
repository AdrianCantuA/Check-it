using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        

    }
}
