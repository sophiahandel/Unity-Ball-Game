﻿using UnityEngine;
using System.Collections;
 

public class Bobber : MonoBehaviour {

    public float amplitude = 0.5f;
    public float frequency = 1f;
 
    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();
 
    void Start () {
        posOffset = transform.position;
    }
     
    // Update is called once per frame
    void Update () {

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
 
        transform.position = tempPos;
    }
}