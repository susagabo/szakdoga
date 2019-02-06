using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegyMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    //public Transform player;
    float force;
    int way=1;


    void Jump()
    {
        rb.velocity = Vector2.up * force;
    }

    void Move()
    {
        rb.velocity = Vector2.right * force*way;
        way = way * (-1);
    }


    // Use this for initialization
    void Start()
    {
        force = 4f;
        InvokeRepeating("Jump", 1, 1.5f);
        InvokeRepeating("Move", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);


    }
}
