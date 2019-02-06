using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsotanyBullet : MonoBehaviour {

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update () {
        rb.velocity = Vector2.right * (-3);
	}
}
