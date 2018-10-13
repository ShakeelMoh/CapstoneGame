using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInvisWall : MonoBehaviour {
    
    private void OnTriggerExit(Collider col)
    {
        GetComponent<Collider>().isTrigger = false;
    }
}
