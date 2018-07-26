﻿using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	private Animator anim;
	public GameObject player1;
	public GameObject player2;
	private float distanceToOpen = 5;
	private int characterNearbyHash = Animator.StringToHash("character_nearby");
	private float distance;
	private float distance2;
	public AudioClip openSound;
	public AudioSource audioSource;
	public float volume = 1.0f;
	bool playSound;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		audioSource = GetComponent<AudioSource> ();
		playSound = true;
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(transform.position, player1.transform.position);
		distance2 = Vector3.Distance(transform.position, player2.transform.position);
		if (distanceToOpen >= distance || distanceToOpen >= distance2){
			if (player1.transform.Find("Indicator").GetComponent<Renderer>().material.color.Equals (gameObject.transform.Find ("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"))){
			//if (obj.GetComponent<Renderer> ().material.color.Equals (gameObject.transform.Find ("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"))) {
				anim.SetBool (characterNearbyHash, true);
				if (playSound) {
					audioSource.PlayOneShot (openSound, volume);
					playSound = false;
				}

			}

		}else{
			//Debug.Log(obj.GetComponent<Renderer> ().material.color + "======" + transform.Find("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"));
			anim.SetBool (characterNearbyHash, false);
			playSound = true;
			
		}

	}
}
