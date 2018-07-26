using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used on moving platform
//When object collides with platform, make platform the parent of the object
public class HoldCharacter : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		other.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider other){
		other.transform.parent = null;
	}
}
