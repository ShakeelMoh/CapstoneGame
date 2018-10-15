using UnityEngine;
using System.Collections;


//Spins pickup around
public class Spin : MonoBehaviour
{
    public float speed = 100f;


    void Update()
    {
		transform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
}