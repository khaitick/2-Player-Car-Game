using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float carSpeed = 20.0f;
    public float turnSpeed = 40.0f;
    public string InputID;

    private float horizontalInput;
    private float forwardInput;

    private void Update()
    {
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal" + InputID);
        forwardInput = Input.GetAxis("Vertical" + InputID);

        // Move vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * forwardInput);
        // Turn the vehicle left and right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput * forwardInput);
    }
}
