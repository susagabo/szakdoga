using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    float force;


    void Jump()
    {
        rb.velocity = Vector2.up * force;
    }


    // Use this for initialization
    void Start()
    {
        force = 4f;
        InvokeRepeating("Jump", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);


    }
}
