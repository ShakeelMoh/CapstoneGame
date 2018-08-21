using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neutralizer : MonoBehaviour {

	//Neutralizes the players active colour

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		other.transform.Find ("Indicator").gameObject.GetComponent<Renderer> ().material.color = Color.white;
	}
}
