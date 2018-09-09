using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject ball;
    public Vector3 distanceBetweenBallAndCamera;

	void Start () {
        distanceBetweenBallAndCamera = transform.position - ball.transform.position;
	}
	
	void LateUpdate () {
        transform.position = ball.transform.position + distanceBetweenBallAndCamera;
	}
}
