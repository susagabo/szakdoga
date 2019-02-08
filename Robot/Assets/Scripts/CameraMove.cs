using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 position;
    public GameObject player;
    //float speed;
    // Use this for initialization
    void Start()
    {
        position = transform.position - player.transform.position;
        transform.TransformVector(position);
        

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //horizontalmove = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        transform.position = player.transform.position + position;
        //transform.Translate(horizontalmove, 0, 0);
    }
}
