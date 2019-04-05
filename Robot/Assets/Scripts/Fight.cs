using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fight : MonoBehaviour
{
    //bool isShooting;
    public Transform firePoint;
    int facing;
    Vector3 position;
    public GameObject bullet;
    public Animator anim;
    bool isShooting = false;
    public GameObject loveseffekt;


    void Shoot()
    {
        isShooting = true;
        anim.SetBool("shoot", isShooting);
        facing = (int)firePoint.rotation.y;
        //Debug.Log(facing);


        if (facing == 0)
        {
            position.x = transform.position.x + 0.4f;
            //Debug.Log("jobb");
        }
        else
        {
            if (facing == (-1))
            {
                position.x = transform.position.x - 0.4f;
                //Debug.Log("bal");
            }
        }



        //position.x = transform.position.x + (float)0.4;
        position.y = transform.position.y - (float)0.03;



        Instantiate(bullet, position, firePoint.rotation);
        //Instantiate(loveseffekt, position, firePoint.rotation);

    }

    void Start()
    {


    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();


            /*
            Debug.Log(position.x);
            Debug.Log(position.y);
            */
        }
    }

    private void LateUpdate()
    {
        isShooting = false;
        anim.SetBool("shoot", isShooting);
    }
}
