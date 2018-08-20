using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourFloor : MonoBehaviour {

	public Color[] colors;
	public Material green;
	public Material yellow;
	public Material blue;
	public Material red;
	public Material white;
	public Material magenta;
	public Material pressedColour;

	public GameObject otherTile;
	private Material otherTileColour;

	private int touchCounter;

	// Use this for initialization
	void Start () {
		colors = new Color[]{red.color, blue.color, yellow.color, magenta.color, green.color, white.color };
		otherTileColour = otherTile.GetComponent<ColourFloor>().pressedColour;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		touchCounter++;
		this.GetComponent<Renderer> ().material = pressedColour;
		if (this.GetComponent<Renderer> ().material.color == otherTile.GetComponent<Renderer> ().material.color) {
			Debug.Log ("GOING TO DO SOMETHING");
			doSomething (1.0f);
		} 
	}

	IEnumerator doSomething(float wait){
		yield return new WaitForSeconds (wait);
		Debug.Log ("DOING SOMETHING");

	}

	void OnCollisionExit(Collision other){
		touchCounter--;
		if (touchCounter == 0) {
			this.GetComponent<Renderer> ().material.color = white.color;
		}
	}
}
