﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Detects button press when within proximity to gameobject
public class DetectButtonPress : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	private float distanceToOpen = 5;

	private float distance;
	private float distance2;
	public AudioClip activateSound;
	public AudioSource audioSource;
	public float volume = 1.0f;

	//Portal variables
	public GameObject portal1;
	public GameObject portal2;
	private ParticleSystem psActivated1;
	private ParticleSystem psActivated2;
	private ParticleSystem psSmoke1;
	private ParticleSystem psSmoke2;

	public GameObject onButton;
	public GameObject offButton;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();

		if (portal1 != null) {
			psActivated1 = portal1.transform.Find ("Activated").GetComponent<ParticleSystem> ();
			psSmoke1 = portal1.transform.Find ("Smoke").GetComponent<ParticleSystem> ();

		}
		if (portal2 != null) {
			psActivated2 = portal2.transform.Find ("Activated").GetComponent<ParticleSystem> ();
			psSmoke2 = portal2.transform.Find ("Smoke").GetComponent<ParticleSystem> ();
		}

		offButton.GetComponent<Renderer> ().material.color = Color.red;
		onButton.GetComponent<Renderer> ().material.color = Color.white;

	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(transform.position, player1.transform.position);
		distance2 = Vector3.Distance(transform.position, player2.transform.position);
		if (distanceToOpen >= distance || distanceToOpen >= distance2) {

			if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.L)) {
				Debug.Log ("Button pressed");
				audioSource.PlayOneShot (activateSound);

				//CHANGE BUTTON COLOURS
				if (offButton.GetComponent<Renderer> ().material.color == Color.red) {
					offButton.GetComponent<Renderer> ().material.color = Color.white;
					onButton.GetComponent<Renderer> ().material.color = Color.green;

				} else if (onButton.GetComponent<Renderer> ().material.color == Color.green) {
					onButton.GetComponent<Renderer> ().material.color = Color.white;
					offButton.GetComponent<Renderer> ().material.color = Color.red;

				}
				if (portal1 != null && portal2 != null) {
					Debug.Log ("TRUE");
					if (psActivated1.isStopped) {
						psActivated1.Play ();
					} else {
						psActivated1.Stop ();
					}
					if (psActivated2.isStopped) {
						psActivated2.Play ();
					} else {
						psActivated2.Stop ();
					}

					if (psSmoke1.isStopped) {
						psSmoke1.Play ();
					} else {
						psSmoke1.Stop ();
					}
					if (psSmoke2.isStopped) {
						psSmoke2.Play ();
					} else {
						psSmoke2.Stop ();
					}
					/*
					psSmoke1.Play ();
					psSmoke2.Play ();

					if (psActivated1.isPlaying) {
						psActivated1.Stop ();
					}
					if (psActivated2.isPlaying) {
						psActivated2.Stop ();
					}
					if (psSmoke1.isPlaying) {
						psSmoke1.Stop ();
					}
					if (psSmoke2.isPlaying) {
						psSmoke2.Stop ();
					}
					*/
				}

			}

		}
		
	}
}
