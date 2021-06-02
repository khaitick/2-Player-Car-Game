using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera cam1;
    public Camera cam2;
    private Vector3 offset = new Vector3(0, 5f, -7f);

    private void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }

    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
