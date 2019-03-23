using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static float health=100;
    float tempHealth=health;
    bool isDead = false;
    public Animator anim;
    public Text healthText;


    // Use this for initialization
    void Start()
    {
        healthText.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        if (health!=tempHealth)
        {
            healthText.text = "Health: " + health;
            tempHealth = health;
        }

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
