using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsotanyBullet : MonoBehaviour
{

    public Rigidbody2D rb;
    //public Text healthText;
    //public PlayerHealth hp;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Bullet"))
            Destroy(gameObject);

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.health -= 30;
            //healthText.text = "Health: " + PlayerHealth.health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right * (-3);
    }
}
