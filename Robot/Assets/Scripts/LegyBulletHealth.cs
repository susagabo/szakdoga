using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegyBulletHealth : MonoBehaviour {

    public int health;
    
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            health -= 10;

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
