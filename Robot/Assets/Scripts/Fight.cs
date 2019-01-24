using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    //bool isShooting;
    public Transform firePoint;
    Vector3 position;
    public GameObject bullet;
    public Animator animator;
    
    
    void Shoot()
    {
        position.x = transform.position.x+(float)0.4;
        position.y = transform.position.y-(float)0.03;
        Instantiate(bullet, position, firePoint.rotation);
        
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
