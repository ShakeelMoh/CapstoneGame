using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour {

	public int speed;

	void OnCollisionEnter(Collision other){

		Debug.Log ("Jump pad triggered");
		other.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * speed);

	}
}
