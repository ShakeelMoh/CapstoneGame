using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Basic script to play sound
public class ActivateSound : MonoBehaviour {

	public AudioSource audioSource;

	public int numberClips = 3;
	public AudioClip[] audioClips;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayClip(int clip){
		audioSource.clip = audioClips [clip];
		audioSource.PlayOneShot (audioClips[clip], 1.0f);

	}


}
