using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static float health=100;
    float tempHealth=health;
    public static bool isDead = false;
    public Animator anim;
    public Text healthText;
    public Canvas canvas;


    
    void Start()
    {
        healthText.text = "Health: " + health;
    }

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

        if (isDead)
            DeathScreen();
    }

    void DeathScreen()
    {
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(3);
        canvas.enabled = true;
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
