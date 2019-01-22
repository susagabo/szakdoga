using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 horizontalmove;
    public GameObject player;
    //float speed;
    // Use this for initialization
    void Start()
    {
        horizontalmove = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //horizontalmove = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        
        transform.position = player.transform.position+horizontalmove;
        //transform.Translate(horizontalmove, 0, 0);
    }
}
