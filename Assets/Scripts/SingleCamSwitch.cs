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

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Player") {

			//only do if the active camera is the split cam
			//sets split cams off and turns on single cam
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
