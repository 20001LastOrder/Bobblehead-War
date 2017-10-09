using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // public variables
    public float movingSpeed = 50.0f;
    public LayerMask layerMask;

    private CharacterController characterController;
    private Vector3 currentLookAt = Vector3.zero;
    //rigidbody of bobbleHead
    public Rigidbody head;
	// Use this for initialization
	void Start () {
        characterController = this.GetComponent<CharacterController>();
	} //end start
	
	// Update is called once per frame
	void Update () {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.SimpleMove(moveDirection * movingSpeed);
	} //end Update

    private void FixedUpdate() {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(moveDirection == Vector3.zero) {
            //TODO
        } else {
            //add force to the right side of the movement
            head.AddForce(this.transform.right * 150, ForceMode.Acceleration);
        } //end if

        //Ray caseting for rotation follows mouse
        RaycastHit hit;  //hit event of the ray casting
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //the following code for visulizing the ray
        //Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);

        //check if the ray hit the target
        if (Physics.Raycast(ray, out hit, 1000, layerMask, QueryTriggerInteraction.Ignore)) {
            if(hit.point != currentLookAt) {
                currentLookAt = hit.point;
            } //end if

            //rotate the player
            Vector3 targetPosition = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
            Quaternion rotation = Quaternion.LookRotation(targetPosition - this.transform.position);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotation, 10.0f * Time.deltaTime);
        }

    }
}
