using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script moves the given platform between two positions
public class MovingPlatform : MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;//startPos
	public Transform position2;//endPos
	public Vector3 newPositon;//Holds next pos
	public string currentState;//Describes current state of platform

	public float speed;//How long it takes to move platform
	public float loopTime;//How long it waits at position

	public bool pressurePlate;
	public bool activatedPlatform;


	void Start () {
		ChangeTarget ();
	}
	

	void FixedUpdate () {//Fixed update runs at consistent interval. Update runs at fps interval.
		if (!pressurePlate) {
			movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPositon, speed * Time.deltaTime);
		} else {
			if (activatedPlatform) {
				movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPositon, speed * Time.deltaTime);
			}
		}

	}

	void ChangeTarget(){

		if (currentState == "Moving to position1") {
			currentState = "Moving to position2";
			newPositon = position2.position;

		} else if (currentState == "Moving to position2") {
			currentState = "Moving to position1";
			newPositon = position1.position;

		} else if (currentState == "") {
			currentState = "Moving to position2";
			newPositon = position2.position;
		}

		Invoke ("ChangeTarget", loopTime);

	}
}
