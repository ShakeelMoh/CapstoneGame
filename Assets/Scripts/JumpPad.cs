using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour {

	public int speed;
	public GameObject player1;
	public GameObject player2;
	void OnCollisionEnter(Collision other){
		
		other.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * speed);

	}
}
