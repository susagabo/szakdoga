using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegyBullet : MonoBehaviour
{

    public Rigidbody2D rb;
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



        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.health -= 50;
            //healthText.text = "Health: " + PlayerHealth.health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
    }
}
