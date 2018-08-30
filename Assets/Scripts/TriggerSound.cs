using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

	public GameObject Intercom;
	public int soundClip;
	bool triggered;

	public GameObject door;
	public GameObject door2;
	public int waitTime;

	//This is for intro level only
	public GameObject light1;
	public GameObject light2;
	public GameObject light3;

	// Use this for initialization
	void Start () {
		triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (!triggered) {
			Intercom.gameObject.GetComponent<ActivateSound> ().PlayClip (soundClip);
			triggered = true;
			StartCoroutine(waitToOpen (waitTime));
		}
	}

	IEnumerator waitToOpen(int waitTime){
		//Debug.Log ("Waiting");
		yield return new WaitForSeconds (waitTime);
		//Debug.Log ("WAITED");
		if (light1 != null && light2 != null && light3 != null) {
			light1.GetComponent<Renderer> ().material.color = Color.green;
			light2.GetComponent<Renderer> ().material.color = Color.green;
			light3.GetComponent<Renderer> ().material.color = Color.green;
		}
		yield return new WaitForSeconds (0.5f);
		if (door != null) {
			door.GetComponent<OpenDoor> ().autoOpen = true;
		}
		if (door2 != null) {
			door2.GetComponent<OpenDoor> ().autoOpen = true;
		}
	}
}
