using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour {


	public int level;
	public Camera multicam;
	public Vector3 offset;
	public Vector3 newOffSet;

	public Camera p1Cam;
	public Camera p2Cam;

	public void incLevel(){
		level++;
		Debug.Log ("LEVEL: " + level);
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
			newOffSet = new Vector3 (-35, 12, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
			multicam.GetComponent<MultipleTargetCamera> ().maxY = 12;
			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 70;
		}
		if (level == 6) {
			newOffSet = new Vector3 (-16, 7, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);

			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 50;

			if (p1Cam != null && p2Cam != null) {
				if (p1Cam.isActiveAndEnabled && p2Cam.isActiveAndEnabled) {
                    p1Cam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
                    p2Cam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
                    //p1Cam.GetComponent<MultipleTargetCamera> ().maxY = 35;
                    //p1Cam.GetComponent<MultipleTargetCamera> ().maxY = 35;
                }
            } else {
				//multicam.GetComponent<MultipleTargetCamera> ().maxY = 9;
			}

		}
		if (level == 7) {
			multicam.GetComponent<MultipleTargetCamera> ().maxY = 35;
		}

		if (level == 8) {
			//Debug.Log ("LEVEL 8");
			newOffSet = new Vector3 (-35, 120, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 80;
			multicam.GetComponent<MultipleTargetCamera> ().maxY = 33;
			multicam.GetComponent<MultipleTargetCamera> ().zoomLimiter = 680;
		}

		if (level == 9) {

			newOffSet = new Vector3 (-35, 120, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
            multicam.GetComponent<MultipleTargetCamera>().maxZoom = 80;
            multicam.GetComponent<MultipleTargetCamera>().maxY = 33;
            multicam.GetComponent<MultipleTargetCamera>().zoomLimiter = 680;
            /*
			multicam.GetComponent<MultipleTargetCamera> ().zoomLimiter = 70;
			multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 70;
			multicam.GetComponent<MultipleTargetCamera> ().maxY = 50;
            */

        }

		if (level == 10) {
			newOffSet = new Vector3 (-35, 120, 0);
			multicam.GetComponent<MultipleTargetCamera> ().setOffset (newOffSet);
            
            multicam.GetComponent<MultipleTargetCamera> ().maxZoom = 75;
            multicam.GetComponent<MultipleTargetCamera>().maxY = 50;
        }

        if (level == 11)
        {
            newOffSet = new Vector3(-16, 7, 0);
            multicam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
            multicam.GetComponent<MultipleTargetCamera>().zoomLimiter = 75;
            multicam.GetComponent<MultipleTargetCamera>().maxZoom = 50;
            multicam.GetComponent<MultipleTargetCamera>().maxY = 35;
        }

        if (level == 12){
            newOffSet = new Vector3(-60, 9, 0);
            if (p1Cam.isActiveAndEnabled && p2Cam.isActiveAndEnabled)
            {
                p1Cam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
                p2Cam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
                p1Cam.GetComponent<MultipleTargetCamera>().maxY = 50;
                p2Cam.GetComponent<MultipleTargetCamera>().maxY = 50;
                //p1Cam.GetComponent<MultipleTargetCamera> ().maxY = 35;
                //p1Cam.GetComponent<MultipleTargetCamera> ().maxY = 35;
            }
            

        }

		if (level == 13) {
			newOffSet = new Vector3 (-60, 15, 0);
            if (p1Cam.isActiveAndEnabled && p2Cam.isActiveAndEnabled)
            {
                p1Cam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
                p2Cam.GetComponent<MultipleTargetCamera>().setOffset(newOffSet);
                p1Cam.GetComponent<MultipleTargetCamera>().maxY = 33;
                p2Cam.GetComponent<MultipleTargetCamera>().maxY = 33;
                
            }
			
		}

	}


}
