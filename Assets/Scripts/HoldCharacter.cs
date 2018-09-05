using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used on moving platform
//When object collides with platform, make platform the parent of the object
public class HoldCharacter : MonoBehaviour {
	/*
	void OnCollisionEnter(Collision other){
		other.transform.parent = gameObject.transform;
	}

	void OnCollisionrExit(Collision other){
		other.transform.parent = null;
	}
	*/

	void OnTriggerEnter(Collider other){
		other.transform.parent = gameObject.transform;
		Vector3 scale = new Vector3 (1.951169f, 1.951168f, 1.951168f);
		//other.transform.parent.localScale = scale;
		//other.transform.localScale = scale;
	}

	void OnTriggerExit(Collider other){
		other.transform.parent = null;
		Vector3 scale = new Vector3 (1.951169f, 1.951168f, 1.951168f);
		other.transform.localScale = scale;
	}

}
