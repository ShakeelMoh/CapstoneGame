using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureTile : MonoBehaviour {


	public Material[] materials;
	public Material green;
	public Material yellow;
	public Material blue;
	public Material red;
	public Material white;
	public Material magenta;
	public Material black;
	public Material currentColour;
	public Material correctColour;

	public int c = 0;
	public GameObject otherTile;
	public ParticleSystem floorGlow;
	// Use this for initialization
	void Start () {
		c = Random.Range (0, 7);

		materials = new Material[]{red, blue, yellow, magenta, green, white, black};
		floorGlow = this.transform.Find ("FloorGlow").GetComponent<ParticleSystem> ();
		floorGlow.Stop ();
		currentColour = materials [c];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		this.GetComponent<Renderer> ().material = materials [c];
		//floorGlow.Play ();
		otherTile.GetComponent<Renderer> ().material = materials[c];
		if (c < materials.Length - 1) {
			c++;
		} else {
			c = 0;
		}

	}

	IEnumerator doSomething(float wait){
		yield return new WaitForSeconds (wait);

	}

	void OnCollisionExit(Collision other){
		if (floorGlow.isPlaying) {
			floorGlow.Stop ();
		}
	}
}
