using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour {

    Rigidbody physic;
    public int speed;
    int scoreCounter= 0;
    public int numberOfCollectedCoins;
    public Text scoreText;
    public Text gameFinishText;

	void Start () {

        physic = GetComponent<Rigidbody>();
		
	}
	
	void FixedUpdate () {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector3 = new Vector3(horizontal, 0 , vertical);

        physic.AddForce(vector3*speed);

	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Coin"){

            other.gameObject.SetActive(false);
            scoreCounter++;
            scoreText.text = "Score : " + scoreCounter;
            //Destroy(other.gameObject);

            if(scoreCounter == numberOfCollectedCoins){
                gameFinishText.text = "OYUN BİTTİ";
            }
        }
	
	}
}
