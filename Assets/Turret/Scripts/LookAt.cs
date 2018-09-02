using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform target;
    public float damping;
    public float offset;
    public LineRenderer colourBeam;
    public ParticleSystem colourParticles;
    public Transform firePoint;
    public float range;
    public string playerTag = "Player";

    private float fireCountdown;
    private float wait;
    private bool bPlay;

    // Use this for initialization
    void Start () {
        colourBeam.enabled = false;
        colourParticles.Stop();
        fireCountdown = 1.0f;
        wait = 3.0f;
        bPlay = false;
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(playerTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }

    }
    // Update is called once per frame
    void Update () {
        if (target != null)
        {
            var lookPos = target.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos) * Quaternion.Euler(0, offset, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            //transform.LookAt(target);
            //Debug.Log(transform.rotation + "|"+rotation);
            //if (transform.rotation.x-rotation.x<0.01&&transform.rotation.y-rotation.y<0.01&&transform.rotation.z-rotation.z<0.01){ 
            //if (transform.rotation == rotation) { 
            colourBeam.enabled = true;
            colourBeam.SetPosition(0, firePoint.position);
            colourBeam.SetPosition(1, target.position);

            

            if (fireCountdown <= 0f&&!bPlay)
            {
                Vector3 dir = target.position - firePoint.position;
                colourParticles.transform.position = firePoint.position;
                colourParticles.transform.rotation = Quaternion.LookRotation(dir);
                colourParticles.Play();
                bPlay = true;
                
            }

            if (bPlay)
            {
                if (wait <= 0f)
                {
                    colourParticles.Stop();
                    wait = 3.0f;
                    bPlay = false;
                    fireCountdown = 5.0f;
                }
                wait -= Time.deltaTime;
            }
            

            fireCountdown -= Time.deltaTime;

        } else
        {
            colourBeam.enabled = false;
            colourParticles.Stop();
        }
        
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
