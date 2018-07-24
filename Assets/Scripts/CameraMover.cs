using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	// VARIABLES
	//

	public float turnSpeed = 4.0f;		// Speed of camera turning when mouse moves in along an axis
	public float panSpeed = 4.0f;		// Speed of the camera when being panned
	public float zoomSpeed = 4.0f;		// Speed of the camera going back and forth

	private Vector3 mouseOrigin;	// Position of cursor when mouse dragging starts
	private bool isPanning;		// Is the camera being panned?
	private bool isRotating;	// Is the camera being rotated?
	private bool isZooming;		// Is the camera zooming?

	public int speed;
	public int moveRightAmnt;
	public int moveBackAmnt;


	//
	// UPDATE
	//

	void Update () 
	{

		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
		}

	}


	//Move camera right


	public void moveRight() {
		//Debug.Log ("Moving rightssssssssss");
		//transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yAxisValue, transform.position.z + zAxisValue);
		transform.Translate(new Vector3(moveRightAmnt,0,0));
	}

	public void moveBack(){
		transform.Translate (new Vector3 (0, 0, moveBackAmnt));
	}


}
