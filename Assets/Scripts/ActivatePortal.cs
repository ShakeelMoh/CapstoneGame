using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script starts a particle effect on portal if player is able to go through it
public class ActivatePortal : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public GameObject portal1;
	public GameObject portal2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.GetComponent<Renderer> ().material.color == player1.transform.Find ("Indicator").GetComponent<Renderer> ().material.color || gameObject.GetComponent<Renderer> ().material.color == player2.transform.Find ("Indicator").GetComponent<Renderer> ().material.color) {
			portal1.transform.Find("Activated").GetComponent<ParticleSystem> ().Play ();
			portal2.transform.Find("Activated").GetComponent<ParticleSystem> ().Play ();
		} else {
			portal1.transform.Find("Activated").GetComponent<ParticleSystem> ().Stop ();
			portal2.transform.Find("Activated").GetComponent<ParticleSystem> ().Stop ();
		}

	}
}
