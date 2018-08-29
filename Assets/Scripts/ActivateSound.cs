using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSound : MonoBehaviour {

	public AudioSource audioSource;
	//public AudioClip allPrisoners;
	//public AudioClip haveEscaped;
	//public AudioClip doorOpening;
	public int numberClips = 3;
	public AudioClip[] audioClips;
	// Use this for initialization
	void Start () {
		//audioClips = new AudioClip[] {allPrisoners, haveEscaped, doorOpening};
		//audioClips = new AudioClip[numberClips];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayClip(int clip){
		Debug.Log ("Play");
		audioSource.clip = audioClips [clip];
		audioSource.PlayOneShot (audioClips[clip], 1.0f);

	}


}
