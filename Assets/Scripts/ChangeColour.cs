using UnityEngine;
using System.Collections;

public class ChangeColour : MonoBehaviour {


	public float respawnDelay;

	// Use this for initialization
	void Start () {
		respawnDelay = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {
			other.transform.Find("Indicator").gameObject.GetComponent<Renderer>().material.color = this.GetComponent<Renderer>().material.GetColor ("_Color");
			//other.transform.GetChild("Indicator").GetComponent<Renderer>().material.color = this.GetComponent<Renderer>().material.GetColor ("_Color");
			//other.GetComponent<Renderer> ().material.color = this.GetComponent<Renderer>().material.GetColor ("_Color");
			//gameObject.SetActive (false);
			Debug.Log(other.GetComponent<Renderer>().material.color + " is new color");
			StartCoroutine (Respawn (respawnDelay));

			}

		}

	IEnumerator Respawn(float respawnDelay){
		gameObject.GetComponent<Renderer> ().enabled = false;
		gameObject.GetComponent<Collider> ().enabled = false;
		yield return new WaitForSeconds (respawnDelay);
		Debug.Log ("Respawning");
		gameObject.GetComponent<Renderer> ().enabled = true;
		gameObject.GetComponent<Collider> ().enabled = true;


	}
}
