using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableParticleSystem : MonoBehaviour {

	// Disables particle system.
	void Start () {
		
		gameObject.GetComponent<ParticleSystem> ().Stop ();

	}

}
