using UnityEngine;
using System.Collections;

public class ChangeColour : MonoBehaviour {


	public float respawnDelay;
	public AudioClip pickupSound;
	public AudioSource audioSource;
	public float volume = 1.0f;
	public bool respawn;
	public int lives;

	public bool rotateColours;
	public float interval;
	public Material green;
	public Material yellow;
	public Material blue;
	public Color[] colors;
	public ParticleSystem glow;
    public ParticleSystem groundPS;
    public GameObject electricOrb;

	int currentColour = 0;

	// Use this for initialization
	void Start () {
		if (blue != null && green != null && yellow != null) {
			colors = new Color[]{ Color.red, blue.color, yellow.color, Color.magenta, green.color };
		}
		respawnDelay = 3.0f;
		if (rotateColours) {
			StartCoroutine (colourChange (interval));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {
            Color pickupColor = this.GetComponent<Renderer>().material.GetColor("_Color");
            other.transform.Find("Indicator").gameObject.GetComponent<Renderer>().material.color = pickupColor;
            other.transform.Find("Indicator").gameObject.GetComponent<Renderer>().materials[1].SetColor("_OutlineColor", pickupColor);
			//other.transform.GetChild("Indicator").GetComponent<Renderer>().material.color = this.GetComponent<Renderer>().material.GetColor ("_Color");
			//other.GetComponent<Renderer> ().material.color = this.GetComponent<Renderer>().material.GetColor ("_Color");
			//gameObject.SetActive (false);
			//Debug.Log(other.GetComponent<Renderer>().material.color + " is new color");
			audioSource.PlayOneShot (pickupSound, volume);
            Debug.Log("HELLO");
			StartCoroutine (Respawn (respawnDelay));
			


			}

		}

	IEnumerator Respawn(float respawnDelay){

		gameObject.GetComponent<Renderer> ().enabled = false;
		gameObject.GetComponent<Collider> ().enabled = false;
		gameObject.transform.Find("Glow").GetComponent<ParticleSystem> ().Stop ();
        electricOrb.transform.Find("ElectricCircle").GetComponent<ParticleSystem>().Stop();
        electricOrb.transform.Find("ElectricParticles").GetComponent<ParticleSystem>().Stop();

        if (respawn) {
			if (lives > 0) {
				lives--;
				yield return new WaitForSeconds (respawnDelay);
				Debug.Log ("Respawning");
				gameObject.transform.Find ("Glow").GetComponent<ParticleSystem> ().Play ();
                electricOrb.transform.Find("ElectricCircle").GetComponent<ParticleSystem>().Play();
                electricOrb.transform.Find("ElectricParticles").GetComponent<ParticleSystem>().Play();
                gameObject.GetComponent<Renderer> ().enabled = true;
				gameObject.GetComponent<Collider> ().enabled = true;

			}
		}
	}

	IEnumerator colourChange(float interval){
		while (true) {
			if (currentColour > colors.Length - 1) {
				currentColour = 0;
			}
			this.GetComponent<Renderer> ().material.color = colors [currentColour];
			var main = glow.main;
			//Debug.Log ("Current colour rgb" + colors [currentColour].ToString());
			float red = colors [currentColour].r + 0.1f;
			float green = colors [currentColour].g + 0.08f;
			float blue = colors [currentColour].b;
			Color glowRGB = new Color (red, green, blue, 1.0f);
			//Debug.Log (red + " " + green + " " + blue);
			main.startColor = glowRGB;

            var electricCircle = electricOrb.transform.Find("ElectricCircle").GetComponent<ParticleSystem>().main;
            var electricParticles = electricOrb.transform.Find("ElectricParticles").GetComponent<ParticleSystem>().main;
            electricCircle.startColor = glowRGB;
            electricParticles.startColor = glowRGB;

            var ground = groundPS.main;
            ground.startColor = glowRGB;



            yield return new WaitForSeconds (interval);
			currentColour++;

		}
	}

}
