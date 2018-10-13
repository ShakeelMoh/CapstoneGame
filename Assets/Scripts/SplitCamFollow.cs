using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//follows a specific player only
public class SplitCamFollow : MonoBehaviour {

    public Transform player;
    public float smoothSpeed = 0.12f;
    public Vector3 offset;

    void FixedUpdate()
    {
        //where the cam wants to be with regard to the player
        Vector3 newPos = player.position + offset;

        //adding the smoothing time
        Vector3 smoothPos = Vector3.Lerp(player.position, newPos, smoothSpeed);

        //move to new location and then look at player
        transform.position = smoothPos;
        transform.LookAt(player);
    }
}
