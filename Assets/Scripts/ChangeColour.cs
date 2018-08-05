using UnityEngine;
using System.Collections;

public class ChangeColour : MonoBehaviour {


	public float respawnDelay;
	public AudioClip pickupSound;
	public AudioSource audioSource;
	public float volume = 1.0f;

	// Use this for initialization
	void Start () {
		respawnDelay = 3.0f;
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
			audioSource.PlayOneShot (pickupSound, volume);
			StartCoroutine (Respawn (respawnDelay));

			}

		}

	IEnumerator Respawn(float respawnDelay){

		gameObject.GetComponent<Renderer> ().enabled = false;
		gameObject.GetComponent<Collider> ().enabled = false;
		gameObject.transform.Find("Glow").GetComponent<ParticleSystem> ().Stop ();
		yield return new WaitForSeconds (respawnDelay);
		Debug.Log ("Respawning");
		gameObject.transform.Find("Glow").GetComponent<ParticleSystem> ().Play ();
		gameObject.GetComponent<Renderer> ().enabled = true;
		gameObject.GetComponent<Collider> ().enabled = true;


	}
}
