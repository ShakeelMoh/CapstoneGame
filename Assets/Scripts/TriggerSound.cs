using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

	public GameObject Intercom;
	public int soundClip;
	bool triggered;
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
		}
	}
}
