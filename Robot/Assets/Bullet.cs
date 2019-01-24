using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        speed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.right * speed;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(gameObject);
        
    }


}
