using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

//Changes Eves walking to spot
public class ChangeAIStopPoint : MonoBehaviour {

	public GameObject robotAI;
	public Transform nextPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "AI") {
			Debug.Log ("CHANGING");
			robotAI.gameObject.GetComponent<AICharacterControl> ().target = nextPoint;

		}
	}
}
