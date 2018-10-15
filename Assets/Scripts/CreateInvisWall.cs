using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Disables trigger script
public class CreateInvisWall : MonoBehaviour {
    
    private void OnTriggerExit(Collider col)
    {
        GetComponent<Collider>().isTrigger = false;
    }
}
