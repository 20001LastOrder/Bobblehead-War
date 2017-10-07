using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletProfeb;
    public Transform launchPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            if (!IsInvoking("fireBullet")) {
                InvokeRepeating("fireBullet", 0f, 0.2f);
            } //end if
        } //end if

        if (Input.GetMouseButtonUp(0)) {
            CancelInvoke("fireBullet");
        }
	}

    void fireBullet() {
        //instanciate the bullet at the position needed in game0
        GameObject bullet = Instantiate(bulletProfeb) as GameObject;
        bullet.transform.position = launchPosition.position;
        bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;
    }
}
