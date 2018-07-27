using System.Collections;
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

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(transform.position, player1.transform.position);
		distance2 = Vector3.Distance(transform.position, player2.transform.position);
		if (distanceToOpen >= distance || distanceToOpen >= distance2) {

			if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.L)) {
				Debug.Log ("Button pressed");
				audioSource.PlayOneShot (activateSound);
			}

		}
		
	}
}
