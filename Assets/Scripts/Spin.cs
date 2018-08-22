﻿using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    public float speed = 100f;


    void Update()
    {
		transform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
}