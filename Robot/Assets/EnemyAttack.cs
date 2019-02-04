using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public GameObject kislegy;
    public Transform firePoint;
    Vector3 position;

    void Attack()
    {
        Instantiate(kislegy, position, transform.rotation);

    }

    // Use this for initialization
    void Start()
    {
        position.x = transform.position.x - 0.5f;
        InvokeRepeating("Attack", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
