using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsotanyAttack : MonoBehaviour
{

    public GameObject trutyi;
    Vector3 position;

    void Attack()
    {
        position.x = transform.position.x - 1.3f;
        position.y = transform.position.y + 0.1f;
        Instantiate(trutyi, position, transform.rotation);

    }


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Attack", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
