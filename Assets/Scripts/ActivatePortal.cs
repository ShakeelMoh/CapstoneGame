﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script starts a particle effect on portal if player is able to go through it
public class ActivatePortal : MonoBehaviour {

    //Portal active?
	public bool active;

    //References to players/portals and particle systems
	public GameObject player1;
	public GameObject player2;

	public GameObject portal1;
	public GameObject portal2;

	private ParticleSystem psActivated1;
	private ParticleSystem psActivated2;

	private ParticleSystem psSmoke1;
	private ParticleSystem psSmoke2;


	// Use this for initialization
	void Start () {
		active = false;
		psActivated1 = portal1.transform.Find ("Activated").GetComponent<ParticleSystem> ();
		psActivated2 = portal2.transform.Find ("Activated").GetComponent<ParticleSystem> ();
		psSmoke1 = portal1.transform.Find ("Smoke").GetComponent<ParticleSystem> ();
		psSmoke2 = portal2.transform.Find ("Smoke").GetComponent<ParticleSystem> ();

	}
	
	// Update is called once per frame
	void Update () {

        //Check if indicators match portal colour
        //Enable/Disable portals/Particle systems
		if (gameObject.GetComponent<Renderer> ().material.color == player1.transform.Find ("Indicator").GetComponent<Renderer> ().material.color || gameObject.GetComponent<Renderer> ().material.color == player2.transform.Find ("Indicator").GetComponent<Renderer> ().material.color) {
	
			active = true;
			portal1.GetComponent<PortalTeleporter> ().enabled = true;
			portal2.GetComponent<PortalTeleporter> ().enabled = true;
			psActivated1.Play ();
			psActivated2.Play ();
			if (!psSmoke1.isPlaying) {
				psSmoke1.Play ();
			}
			if (!psSmoke2.isPlaying) {
				psSmoke2.Play ();
			}

		} else {
            Debug.Log(gameObject.GetComponent<Renderer>().material.color + " --" + player1.transform.Find("Indicator").GetComponent<Renderer>().material.color);
			portal1.GetComponent<PortalTeleporter> ().enabled = false;
			portal2.GetComponent<PortalTeleporter> ().enabled = false;
            
			active = false;
			if (psSmoke1.isPlaying) {
				psSmoke1.Stop ();
			}
			if (psSmoke2.isPlaying) {
				psSmoke2.Stop ();
			}
			if (psActivated1.isPlaying) {
				psActivated1.Stop ();
			}
			if (psActivated2.isPlaying) {
				psActivated2.Stop ();
			}

		}

	}
}
