using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class EveInteract : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public float distanceToOpen = 4;

    private float distance;
    private float distance2;
    public AudioClip activateSound;
    public AudioSource audioSource;
    public float volume = 1.0f;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(transform.position, player1.transform.position);
        distance2 = Vector3.Distance(transform.position, player2.transform.position);
            if (distanceToOpen >= distance)
            {
                if (CrossPlatformInputManager.GetButtonDown("Use"))
                {

                    audioSource.PlayOneShot(activateSound);
                    

                }
            }
            //Sorry for this...
            if (distanceToOpen >= distance2)
            {
                if (CrossPlatformInputManager.GetButtonDown("Use2"))
                {
                    //Debug.Log ("Button pressed");
                    audioSource.PlayOneShot(activateSound);

                }
            }
        }

    }
