using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegyAttack : MonoBehaviour
{

    public GameObject kislegy;
    //public Transform player;
    Vector3 position;

    void Attack()
    {
        position.x = transform.position.x - 0.5f;
        position.y = transform.position.y;
        Instantiate(kislegy, position, transform.rotation);

    }

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Attack", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
