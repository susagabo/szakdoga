using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    bool isShooting;
    public Transform firePoint;
    public GameObject bullet;
    public Animator animator;

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        
    }

    void Start()
    {


    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
}
