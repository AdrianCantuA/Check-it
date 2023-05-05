using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crash : MonoBehaviour
{
    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
   
  
}
