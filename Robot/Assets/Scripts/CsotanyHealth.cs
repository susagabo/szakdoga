using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsotanyHealth : MonoBehaviour
{

    public float health;
    public GameObject csotany;
    Vector3 position;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            health -= 10;
    }


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
            position.x = transform.position.x + 0.5f;
            position.y = transform.position.y + 0.5f;
            Instantiate(csotany, position, transform.rotation);

            position.x = transform.position.x - 0.5f;
            position.y = transform.position.y + 0.5f;
            Instantiate(csotany, position, transform.rotation);
            //position.x = transform.position.x - 3;
            position.y = transform.position.y + 1;
            Instantiate(csotany, position, transform.rotation);
            
        }

    }
}
