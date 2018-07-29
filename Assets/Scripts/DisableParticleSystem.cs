using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableParticleSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		gameObject.GetComponent<ParticleSystem> ().Stop ();

	}

}
