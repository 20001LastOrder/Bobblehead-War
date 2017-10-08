using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float movingSpeed = 50.0f;
    private CharacterController characterController;

	// Use this for initialization
	void Start () {
        characterController = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.SimpleMove(moveDirection * movingSpeed);
	}
}
