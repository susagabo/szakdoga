using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health;
    bool isDead = false;
    public Animator anim;

    // Use this for initialization
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            health -= 50;
        if (isDead)
            anim.SetBool("dead",isDead);
    }
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            health -= 50;

        if (health <= 0)
            isDead = true;

        if (isDead)
            anim.SetBool("die", isDead);
    }
}
