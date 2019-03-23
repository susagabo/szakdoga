using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = transform.right * speed;

        /*
        if (transform.rotation.y == 0)
            rb.velocity = transform.right * speed;
        else
            rb.velocity = transform.right * speed*(-1);
        */
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Bullet"))
            //Destroy(collision.gameObject);
            Destroy(gameObject);
        /*
        if (collision.gameObject.CompareTag("Enemy"))
        collision.gameObject.
        */
    }

    private void LateUpdate()
    {
        rb.velocity = transform.right * speed;

        /*
        if (transform.rotation.y == 0)
            rb.velocity = transform.right * speed;
        else
            rb.velocity = transform.right * speed*(-1);
        */
    }
}
