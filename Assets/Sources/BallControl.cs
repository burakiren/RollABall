using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    Rigidbody physic;
    public int speed;

	void Start () {

        physic = GetComponent<Rigidbody>();
		
	}
	
	void FixedUpdate () {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector3 = new Vector3(horizontal, 0 , vertical);

        physic.AddForce(vector3*speed);

	}
}
