using UnityEngine;
using System.Collections;

//Opens door for player if certain conditions are met.
public class OpenDoor : MonoBehaviour {

	private Animator anim;
	public GameObject player1;
	public GameObject player2;
	public float distanceToOpen = 10;
	private int characterNearbyHash = Animator.StringToHash("character_nearby");
	private float distance;
	private float distance2;
	public AudioClip openSound;
	public AudioClip openAnnouncer;
	bool playedAnnouncer = false;
	public AudioSource audioSource;
	public float volume = 0.1f;
	bool playSound;

	public bool autoOpen;

	public bool pressurePlate;
	public bool activateDoor;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		audioSource = GetComponent<AudioSource> ();
		audioSource.volume = 0.1f;
		playSound = true;
		activateDoor = false;
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance (transform.position, player1.transform.position);
		distance2 = Vector3.Distance (transform.position, player2.transform.position);
		if (autoOpen) {
			if (distanceToOpen >= distance || distanceToOpen >= distance2) {
				anim.SetBool (characterNearbyHash, true);
				if (playSound) {
					audioSource.PlayOneShot (openAnnouncer, volume);
					audioSource.PlayOneShot (openSound, volume);
					playSound = false;
				}
			} else {
				anim.SetBool (characterNearbyHash, false);
				playSound = true;
			}
		} else {
			if (player1.transform.Find ("Indicator").GetComponent<Renderer> ().material.color.Equals (gameObject.transform.Find ("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"))) {
				if (player2.transform.Find ("Indicator").GetComponent<Renderer> ().material.color.Equals (gameObject.transform.Find ("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"))) {
					//if (obj.GetComponent<Renderer> ().material.color.Equals (gameObject.transform.Find ("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"))) {
					anim.SetBool (characterNearbyHash, true);
					if (playSound) {
						audioSource.PlayOneShot (openSound, volume);
						playSound = false;
					}
				}

			} else {
				//Debug.Log(obj.GetComponent<Renderer> ().material.color + "======" + transform.Find("door_2_left").GetComponent<Renderer> ().material.GetColor ("_Color"));
				anim.SetBool (characterNearbyHash, false);
				playSound = true;
			}


			if (pressurePlate) {
				
				if (activateDoor) {
					//Debug.Log ("Open door");
					//Debug.Log("WTF");
					if (!playedAnnouncer) {
						playedAnnouncer = true;
						audioSource.PlayOneShot (openAnnouncer, 0.1f);
					}
					anim.SetBool (characterNearbyHash, true);
				} else {
					//Debug.Log ("Close Door");
					anim.SetBool (characterNearbyHash, false);
				}
               
                

			}
		

		}
	}

	IEnumerator waitForAnnouncer(){
		yield return new WaitForSeconds (2);
	}
}
