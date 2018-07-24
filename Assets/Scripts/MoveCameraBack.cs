using UnityEngine;
using System.Collections;

public class MoveCameraBack : MonoBehaviour {

	public GameObject otherPortal;
	public CameraMover cm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		cm.moveBack ();

	}

}
