using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//falling objects that hit this get destroyed, and if its a player they get respawned

public class FallingObjectDestroyer : MonoBehaviour {

    public GameObject levelTracker; //To keep track of current level
    public GameObject levelSpawnAreas;
    public GameObject Player1;
    public GameObject Player2;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            int level = levelTracker.gameObject.GetComponent<LevelTracker>().level;
            transform.position = levelSpawnAreas.transform.Find(level + "").position;
        }
        else
            Destroy(col.gameObject);
    }
}
