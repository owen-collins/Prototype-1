﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float fowardInput;

      // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        // We'll move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
       transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
       }
}