using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    //use this to destry the object when it cannot be seen by any camera
    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision) {
        Destroy(this.gameObject);
    }
}
