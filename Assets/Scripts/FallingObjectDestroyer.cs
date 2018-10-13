using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//falling objects that hit this get destroyed, and if its a player they get respawned
using UnityStandardAssets.Characters.ThirdPerson;
public class FallingObjectDestroyer : MonoBehaviour {

    public GameObject levelTracker; //To keep track of current level
    public GameObject levelSpawnAreas;
    public GameObject Player1;
    public GameObject Player2;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (col.gameObject.name == "PLAYER 2")
            {
                Player2.GetComponent<Player2UserControl>().playerReset();
            }
            else
                col.gameObject.GetComponent<ThirdPersonUserControl>().playerReset();
        }
        else
            Destroy(col.gameObject);
    }
}
