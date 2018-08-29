using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

	public GameObject Intercom;
	public int soundClip;
	bool triggered;

	public GameObject door;
	public int waitTime;
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
		Debug.Log ("Waiting");
		yield return new WaitForSeconds (waitTime);
		Debug.Log ("WAITED");
		door.GetComponent<OpenDoor> ().autoOpen = true;
	}
}
