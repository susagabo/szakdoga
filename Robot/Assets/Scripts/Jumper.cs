using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

    public Rigidbody2D playerRb;

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerRb.velocity = Vector2.up * 10;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
