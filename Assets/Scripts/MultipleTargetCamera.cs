using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Camera that keeps track of both players at the same time
[RequireComponent(typeof(Camera))]
public class MultipleTargetCamera : MonoBehaviour {

	public List<Transform> targets;//Camera targets
	public Vector3 offset;//Offset from players
	private Vector3 velocity;//Stuff
	public float smoothTime = .5f;
	public float minZoom = 40f;//Field of view value
	public float maxZoom = 10f;//Field of view value
	public float zoomLimiter = 50f;

	private Camera cam;

	void Start(){
		cam = GetComponent<Camera> ();
	}

	public void setOffset(Vector3 newOffset){
		offset = newOffset;
	}
	public Vector3 getOffset(){
		return offset;
	}

	void LateUpdate(){

		if (targets.Count == 0) {
			return;
		}

		Move ();
		Zoom ();
	}

	void Move(){

		Vector3 centrePoint = GetCentrePoint ();
		Vector3 newPosition = centrePoint + offset;
		transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime); 

	}

	void Zoom(){
		
		float newZoom = Mathf.Lerp (maxZoom, minZoom, GetGreatestDistance ()/ zoomLimiter);
		cam.fieldOfView = Mathf.Lerp (cam.fieldOfView, newZoom, Time.deltaTime);
	}

	float GetGreatestDistance(){
		var bounds = new Bounds (targets [0].position, Vector3.zero);
		for (int i = 0; i < targets.Count; i++) {
			bounds.Encapsulate (targets [i].position);
		}

		return bounds.size.x;
	}

	//Obtains centre point
	Vector3 GetCentrePoint(){

		if (targets.Count == 1) {
			return targets [0].position;
		}

		var bounds = new Bounds (targets [0].position, Vector3.zero);
		for (int i = 0; i < targets.Count; i++) {
			bounds.Encapsulate (targets [i].position);
		}

		return bounds.center;
	}
}
