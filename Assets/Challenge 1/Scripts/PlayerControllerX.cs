﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject propeller;

    public float speed = 25.0f;
    public float rotationSpeed = 50.0f;
    private float verticalInput;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical1");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);

        // Rotate propeller
        propeller.transform.Rotate(Vector3.forward * Time.deltaTime * speed * 10);
    }
}
