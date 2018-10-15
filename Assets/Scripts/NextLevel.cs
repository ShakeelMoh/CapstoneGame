using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

//Changes current level when players collide with trigger.
public class NextLevel : MonoBehaviour {

	// Use this for initialization

	bool changed;
	public GameObject levelTracker;
	public bool split;
	void Start () {
		//level = levelTracker.GetComponent<LevelTracker> ().level;
		changed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		//Debug.Log (transform.position);
		//Debug.Log ("Changing level");
		if (changed == false && !split) {
			
			//Debug.Log ("Changing level");
			levelTracker.GetComponent<LevelTracker> ().level++;
			changed = true;

            //set which player spawns on top and the bottom
            if (levelTracker.GetComponent<LevelTracker>().level == 13)
            {
                if (other.gameObject.name == "PLAYER 1")
                {
                    other.GetComponent<ThirdPersonUserControl>().lvl13spawn = "top";
                }
                else
                    other.GetComponent<Player2UserControl>().lvl13spawn = "top";
            }
            if (levelTracker.GetComponent<LevelTracker>().level == 6)
            {
                if (other.gameObject.name == "PLAYER 1")
                {
                    other.GetComponent<ThirdPersonUserControl>().lvl6spawn = "1st";
                }
                else
                    other.GetComponent<Player2UserControl>().lvl6spawn = "1st";
            }
        }

	}

}
