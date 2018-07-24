using UnityEngine;
using System.Collections;

public class StepThroughPortal2 : MonoBehaviour {

	//DOESNT MOVE THE CAMERA RIGHT

	public GameObject otherPortal;
	public int spawn;
	public int currentCamPos;

	void Start () {
		//cm = new CameraMover ();
	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {
			if (other.GetComponent<Renderer> ().material.color == this.GetComponent<Renderer>().material.GetColor ("_Color")){
				other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * spawn;

			}

		}
	}

}
