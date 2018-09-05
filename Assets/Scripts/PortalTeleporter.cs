using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Teleports player if they step through the portal
public class PortalTeleporter : MonoBehaviour {

	public GameObject otherPortal;
	public GameObject colourChecker;
	public float placementOffset;

	public bool sameWall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (colourChecker.GetComponent<ActivatePortal> ().active) {
			if (other.transform.Find ("Indicator").GetComponent<Renderer> ().material.color == colourChecker.GetComponent<Renderer> ().material.color) {
				other.transform.position = otherPortal.transform.position - otherPortal.transform.up * placementOffset;

				if (sameWall) {
					Vector3 v3 = other.attachedRigidbody.velocity;
					v3.z *= -1;
					v3.x *= -1;
					other.attachedRigidbody.velocity = v3;
					//other.attachedRigidbody.velocity *= -1;
					Debug.Log(v3.ToString());
					other.transform.Rotate (0, 180, 0);
				}
			}
		}
	}
}
