using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class TriggerEve : MonoBehaviour {

    public GameObject eve;
    public GameObject target;
    public GameObject target2;
    public int waitTime;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator OnTriggerEnter(Collider other)
    {
        yield return new WaitForSeconds(waitTime);
        eve.gameObject.GetComponent<AICharacterControl>().target = target.transform;
        eve.gameObject.transform.LookAt(target2.transform);
    }
}
