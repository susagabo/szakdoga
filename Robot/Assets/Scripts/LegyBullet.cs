﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegyBullet : MonoBehaviour
{

    public Rigidbody2D rb;
    //public PlayerHealth hp;
    float speed;

    // Use this for initialization
    void Start()
    {
        speed = -1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);



        if (collision.gameObject.CompareTag("Player"))
            PlayerHealth.health -= 50;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
    }
}
