using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMount : MonoBehaviour {
    public GameObject followingTarget;
    public float followingSpeed; 

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
        if (followingTarget != null) {
            //the Lerp method return a Vector 3 point between first two arguments based on the last float value
            this.transform.position = Vector3.Lerp(this.transform.position, followingTarget.transform.position, Time.deltaTime * followingSpeed);
        }


    }
}
