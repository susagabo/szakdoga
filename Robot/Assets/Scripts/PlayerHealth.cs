using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public static float health=100;
    bool isDead = false;
    public Animator anim;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            isDead = true;

        if (isDead)
            anim.SetBool("die", isDead);
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
     /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            health -= 50;
        
    }
    */
}
