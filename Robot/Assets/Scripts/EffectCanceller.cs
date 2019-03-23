using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCanceller : MonoBehaviour {

    
    //Animation shrink = gameObject.GetComponent<Animation>();

    // Use this for initialization
    void Start () {

        //effect.Play();
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
	
	// Update is called once per frame
	void Update () {
        //Animation effect=gameObject.GetComponent<Animation>();
        //Destroy(gameObject, effect.clip.length);
    }
}
