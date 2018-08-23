﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour {


	public int level;
	public Camera multicam;
	public Vector3 offset;
	public Vector3 newOffSet;

	public void incLevel(){
		level++;
	}

	// Use this for initialization
	void Start () {
		offset = multicam.GetComponent<MultipleTargetCamera> ().getOffset();
	}
	
	// Update is called once per frame
	void Update () {
		if (level == 0) {
			newOffSet = new Vector3 (-16, 7, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
		}

		if (level == 3) {
			newOffSet = new Vector3 (-25, 10, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
		}
		if (level == 4) {
			newOffSet = new Vector3 (-35, 8, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
		}
		if (level == 5) {
			newOffSet = new Vector3 (-35, 8, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 70;
		}

		if (level == 9) {
			newOffSet = new Vector3 (-35, 30, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 70;
		}

		if (level == 12) {
			newOffSet = new Vector3 (-60, 30, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 90;
			multicam.GetComponent<MultipleTargetCamera> ().minZoom = 50;
			multicam.GetComponent<MultipleTargetCamera> ().maxY = 20;
		}

	}


}
