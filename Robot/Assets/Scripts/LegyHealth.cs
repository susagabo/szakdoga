using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegyHealth : MonoBehaviour
{

    public int health;
    public GameObject coin;
    Vector3 position;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            position.x = transform.position.x;
            position.y = transform.position.y;
            Instantiate(coin, position, transform.rotation);
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            health -= 10;

    }





    /*
    if (collision.gameObject.CompareTag("Bullet"))
    {
        health -= 10;
        Debug.Log(health);
    }
    */

}
