using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

	public GameObject door;
	public GameObject platform;
	public bool togglePlatform;
	// Use this for initialization
	void Start () {
		if (door != null) {
			door.GetComponent<OpenDoor> ().pressurePlate = true;
			door.GetComponent<OpenDoor> ().activateDoor = false;
		}
		if (platform != null) {
			platform.GetComponent<MovingPlatform> ().pressurePlate = true;
			platform.GetComponent<MovingPlatform> ().activatedPlatform = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("Pressure plate triggered");

		if (door != null) {
			door.GetComponent<OpenDoor> ().activateDoor = true;
		}
		if (platform != null) {
			if (togglePlatform) {
				platform.GetComponent<MovingPlatform> ().activatedPlatform = true;
			}
			platform.GetComponent<MovingPlatform> ().activatedPlatform = true;
		}
	}

	void OnCollisionExit(Collision other){
		Debug.Log ("Pressure plate deactivated");
		if (door != null) {
			door.GetComponent<OpenDoor> ().activateDoor = false;
		}
		if (platform != null) {
			if (!togglePlatform) {
				platform.GetComponent<MovingPlatform> ().activatedPlatform = false;
			}
		}
	}
}
