using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//class that allows the cameras to be switched to split screen cameras upon impact
//put this on the ground at the beginning of splitscreen levels or single cam levels

public class SplitScreenSwitch : MonoBehaviour {

	public GameObject splitCam1;
	public GameObject splitCam2;
	public GameObject singleCam;
	public Image screenDivider;

	void OnCollisionEnter(Collision other){

		//only do if the active camera is the single cam
		//sets split cams on and turns off single cam
		if (singleCam.activeSelf) {


			splitCam1.SetActive (true);
			splitCam2.SetActive (true);

			singleCam.SetActive (false);

			//turn on screen divider
			screenDivider.enabled = true;
		} 
	}
}
