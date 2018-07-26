using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePointMovingPlatform : MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;//startPos
	public Transform position2;//nextPos
	public Transform position3;//lastPos
	public Vector3 newPositon;//Holds next pos
	public string currentState;//Describes current state of platform
	bool forwards;

	public float speed;//How long it takes to move platform
	public float loopTime;//How long it waits at position

	void Start () {
		forwards = true;
		ChangeTarget ();
	}


	void FixedUpdate () {//Fixed update runs at consistent interval. Update runs at fps interval.

		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPositon, speed * Time.deltaTime);
	}

	void ChangeTarget(){

		if (currentState == "Moving to position1") {
			currentState = "Moving to position2";
			forwards = true;
			newPositon = position2.position;

		} else if (currentState == "Moving to position2") {
			if (forwards) {
				currentState = "Moving to position3";
				newPositon = position3.position;
			} else {
				currentState = "Moving to position1";
				newPositon = position1.position;
			}


		} else if (currentState == "Moving to position3"){
			currentState = "Moving to position2";
			forwards = false;
			newPositon = position2.position;

		} else if (currentState == "") {
			currentState = "Moving to position2";
			newPositon = position2.position;
		} 

		Invoke ("ChangeTarget", loopTime);

	}
}
