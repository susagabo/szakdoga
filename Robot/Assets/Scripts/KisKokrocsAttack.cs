using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KisKokrocsAttack : MonoBehaviour {

    public Rigidbody2D rb;
    readonly float force=3f;

    void Attack()
    {
        rb.velocity = Vector2.left * force;
        rb.velocity = Vector2.up * force;
    }

	// Use this for initialization
	void Start () {

       InvokeRepeating("Attack",1,2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
