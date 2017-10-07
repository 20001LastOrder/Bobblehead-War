using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float movingSpeed = 50.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.position;
        position.x += movingSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        position.z += movingSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        this.transform.position = position;
	}
}
