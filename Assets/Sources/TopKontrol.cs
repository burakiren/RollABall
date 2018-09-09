using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour {

    Rigidbody physic;
    public int speed;

	void Start () {

        physic = GetComponent<Rigidbody>();
		
	}
	
	void fixedUpdate () {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector3 = new Vector3(horizontal, 0 , vertical);

        physic.AddForce(vector3*speed);

	}
}
