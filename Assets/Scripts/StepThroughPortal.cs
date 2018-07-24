using UnityEngine;
using System.Collections;

public class StepThroughPortal : MonoBehaviour {

	public GameObject otherPortal;
	public int spawn;
	public int currentCamPos;

	public CameraMover cm;


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
				cm.moveRight ();
				Debug.Log (other.GetComponent<Renderer> ().material.color);
			}

		}
	}

}
