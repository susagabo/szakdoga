using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegyBullet : MonoBehaviour
{

    public Rigidbody2D rb;
    bool grounded = false;
    //public Text healthText;
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

        if (grounded == false && collision.gameObject.CompareTag("Ground"))
            grounded = true;

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.health -= 50;
            //healthText.text = "Health: " + PlayerHealth.health;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (grounded == true && collision.gameObject.CompareTag("Ground"))
            grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded)
            rb.velocity = transform.right * speed;
    }
}
