using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Teleports player if they step through the portal
public class PortalTeleporter : MonoBehaviour {

	public GameObject otherPortal;
	public float placementOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		other.transform.position = otherPortal.transform.position + otherPortal.transform.up * placementOffset;

	}
}
