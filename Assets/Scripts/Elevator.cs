using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

	public GameObject door;
	public GameObject otherDoor;

	private int touching;
	public float closeDoorWait = 1.5f;
	// Use this for initialization
	void Start () {
		if (door != null) {
			door.GetComponent<OpenDoor> ().pressurePlate = true;
			door.GetComponent<OpenDoor> ().activateDoor = false;
		}
		touching = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		touching++;
		if (touching == 2) {
			StartCoroutine (closeDoor (closeDoorWait));
		}
	}

	void OnCollisionExit(Collision other){
		touching--;
	}

	IEnumerator closeDoor(float closeDoorWait){
		
		yield return new WaitForSeconds (closeDoorWait);
		if (touching == 2) {
			door.GetComponent<OpenDoor> ().activateDoor = false;
			door.GetComponent<OpenDoor> ().autoOpen = false;
			this.GetComponent<ElevatorPlatform> ().activatedPlatform = true;
		}
	}
}

