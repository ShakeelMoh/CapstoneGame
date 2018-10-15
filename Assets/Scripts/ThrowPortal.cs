using UnityEngine;
using System.Collections;


//Not used
public class ThrowPortal : MonoBehaviour {

	public GameObject leftPortal;
	public GameObject rightPortal;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  
		//Left Click
		if (Input.GetMouseButtonDown (0)) {
			throwPortal (leftPortal);
		}
		//Right Click
		if (Input.GetMouseButtonDown (1)) {
			throwPortal (rightPortal);
		}
			
	}

	void throwPortal(GameObject portal){
		int x = Screen.width / 2;
		int y = Screen.height / 2;

		Ray ray = Camera.main.ScreenPointToRay(new Vector3(x,y));
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit)){
			Quaternion hitObjectRotation = Quaternion.LookRotation (hit.normal);
			portal.transform.position = hit.point;
			portal.transform.rotation = hitObjectRotation;
		}


	}
}
