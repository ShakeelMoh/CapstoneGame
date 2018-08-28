using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neutralizer : MonoBehaviour {

	//Neutralizes the players active colour
	public GameObject player1;
	public GameObject player2;
	private bool p1;
	private bool p2;
	private int count;

	public bool neutralizeAnyway; //Neutralizes colours regardless
	// Use this for initialization
	void Start () {
		p1 = false;
		p2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (p1 && p2) {
			player1.transform.Find ("Indicator").gameObject.GetComponent<Renderer> ().material.color = Color.white;
			player2.transform.Find ("Indicator").gameObject.GetComponent<Renderer> ().material.color = Color.white;
			p1 = false;
			p2 = false;
		}
	}

	void OnTriggerEnter(Collider other){

		if (neutralizeAnyway) {
			p1 = true;
			p2 = true;
		}
		if (other.gameObject == player1.gameObject && !p1) {
			//other.transform.Find ("Indicator").gameObject.GetComponent<Renderer> ().material.color = Color.white;
			p1 = true;
		}
		if (other.gameObject == player2.gameObject && !p2) {
			//other.transform.Find ("Indicator").gameObject.GetComponent<Renderer> ().material.color = Color.white;
			p2 = true;
		}
	}
}
