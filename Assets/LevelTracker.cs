using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour {


	public int level;
	public Camera multicam;
	public Vector3 offset;

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
			Vector3 newOffset = new Vector3 (-16, 7, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffset);
		}
		if (level == 1) {
			Vector3 newOffset = new Vector3 (-25, 7, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffset);
		}
	}


}
