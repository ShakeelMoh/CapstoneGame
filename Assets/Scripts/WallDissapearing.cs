using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDissapearing : MonoBehaviour {

    public List<GameObject> walls; //all the objects to fall in order
    public float initWaitTime;

    // Update is called once per frame
    void Update()
    {

    }

    //on collision with the floor this method runs
    IEnumerator OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {

            //waiting time for narrative and player o make a plan to survive
            yield return new WaitForSeconds(initWaitTime);

            
            for (int i = 0; i < walls.Count; i++) {
            		Destroy (walls[i]);
            	}
        }
    }
}
