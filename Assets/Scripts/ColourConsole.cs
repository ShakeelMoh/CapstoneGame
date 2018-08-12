﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Changes colour of portal when button pressed
public class ColourConsole : MonoBehaviour {

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
	private ParticleSystem baseColor1;
	private ParticleSystem baseColor2;
	private ParticleSystem psActivated1;
	private ParticleSystem psActivated2;
	private ParticleSystem psSmoke1;
	private ParticleSystem psSmoke2;

	public GameObject colourChecker;

	public Material green;
	public Material yellow;
	public Color[] colors;
	//public Color[] colors = {Color.red, Color.blue, Color.yellow, Color.green, Color.magenta};
	public Color currentColor;
	public GameObject button;
	int colorCounter = 0;

	// Use this for initialization
	void Start () {
		colors = new Color[]{Color.red, Color.blue, yellow.color, Color.magenta, green.color };
		audioSource = GetComponent<AudioSource> ();

		if (portal1 != null) {
			psActivated1 = portal1.transform.Find ("Activated").GetComponent<ParticleSystem> ();
			psSmoke1 = portal1.transform.Find ("Smoke").GetComponent<ParticleSystem> ();
			baseColor1 = portal1.transform.Find ("Base").GetComponent<ParticleSystem> ();


		}
		if (portal2 != null) {
			psActivated2 = portal2.transform.Find ("Activated").GetComponent<ParticleSystem> ();
			psSmoke2 = portal2.transform.Find ("Smoke").GetComponent<ParticleSystem> ();
			baseColor2 = portal2.transform.Find ("Base").GetComponent<ParticleSystem> ();

		}

		button.GetComponent<Renderer> ().material.color = currentColor;

	}

	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(transform.position, player1.transform.position);
		distance2 = Vector3.Distance(transform.position, player2.transform.position);
		if (distanceToOpen >= distance || distanceToOpen >= distance2) {

			if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.L)) {
				Debug.Log ("Button pressed");
				audioSource.PlayOneShot (activateSound);
				if (colorCounter < colors.Length) {
					button.GetComponent<Renderer> ().material.color = colors [colorCounter];

					var main = psSmoke1.main;
					main.startColor = colors [colorCounter];

					colourChecker.GetComponent<Renderer> ().material.color = colors [colorCounter];


					main = psSmoke2.main;
					main.startColor = colors [colorCounter];

					main = psActivated1.main;
					main.startColor = colors [colorCounter];

					main = psActivated2.main;
					main.startColor = colors [colorCounter];

					main = baseColor1.main;
					main.startColor = colors [colorCounter];
					baseColor1.GetComponent<ParticleSystem>().Stop ();
					baseColor1.GetComponent<ParticleSystem>().Clear ();
					baseColor1.GetComponent<ParticleSystem>().Play ();

					main = baseColor2.main;
					main.startColor = colors [colorCounter];
					baseColor2.GetComponent<ParticleSystem>().Stop ();
					baseColor2.GetComponent<ParticleSystem> ().Clear ();
					baseColor2.GetComponent<ParticleSystem>().Play ();

					colorCounter++;
				} else {
					colorCounter = 0;
					button.GetComponent<Renderer> ().material.color = colors [colorCounter];
				}

			}

		}

	}

}
