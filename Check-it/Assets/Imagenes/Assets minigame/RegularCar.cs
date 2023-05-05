using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularCar : MonoBehaviour
{

    public float carVelocity;
    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = new Vector2(0, carVelocity);
    }
    void Update()
    {
     if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
}
}
