using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;//startPos
	public Transform position2;//endPos
	public Vector3 newPositon;//Holds next pos
	public string currentState;//Describes current state of platform

	public float speed;//How long it takes to move platform
	public float loopTime;//How long it waits at position
	public bool activatedPlatform;

	void Start () {
		ChangeTarget ();
	}


	void FixedUpdate () {//Fixed update runs at consistent interval. Update runs at fps interval.
		if (activatedPlatform) {
			this.transform.position = Vector3.Lerp (this.transform.position, newPositon, speed * Time.deltaTime);
		}
	}
		

	void ChangeTarget(){
		newPositon = position2.position;

	}
}
