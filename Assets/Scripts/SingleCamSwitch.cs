using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//class that allows the cameras to be switched to single camera upon impact
//put this on the ground at the beginning of splitscreen levels or single cam levels

public class SingleCamSwitch : MonoBehaviour {

	public GameObject splitCam1;
	public GameObject splitCam2;
	public GameObject singleCam;
	public Image screenDivider;

	public GameObject player1;
	public GameObject player2;

	bool p1;
	bool p2;
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject == player1) {
			p1 = true;
		}
		if (other.gameObject == player2) {
			p2 = true;
			Debug.Log ("TRUE2");
		}
			//only do if the active camera is the split cam
			//sets split cams off and turns on single cam
		if (p1 && p2) {
			if (!singleCam.activeSelf) {
				splitCam1.SetActive (false);
				splitCam2.SetActive (false);

				singleCam.SetActive (true);

				//turn off screen divider
				screenDivider.enabled = false;
			}
		}
	}
}
