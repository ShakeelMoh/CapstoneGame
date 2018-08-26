using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is put on a certain ground floor, and when this is collided with by the player,
//the room will fall apart in the order described by the order of room pieces

//use: put on ground at beginning of level and enter the pieces ofroom you want to fall apart in order of their falling
//note: rigidbody must be added to all these pieces with all the ontraints initially ticked
public class RoomDestruction : MonoBehaviour {

	public List<GameObject> fallingOrder; //all the objects to fall in order
	public float initWaitTime;
	public float fallingSpeed;

	// Update is called once per frame
	void Update () {

	}

	//on collision with the floor this method runs
	IEnumerator OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Player") {

			//waiting time for narrative and player o make a plan to survive
			yield return new WaitForSeconds (initWaitTime);

			for (int i = 0; i < fallingOrder.Count; i++) {
				Rigidbody rb = fallingOrder [i].GetComponent<Rigidbody> ();
				rb.isKinematic = false; //allows it to fall
				yield return new WaitForSeconds (fallingSpeed);//allows he different parts of the level to fall in order in time
			}

			//destroy all fallen pieces
			for (int i = 0; i < fallingOrder.Count; i++) {
				Destroy (fallingOrder [i]);
			}
		}
	}

}
