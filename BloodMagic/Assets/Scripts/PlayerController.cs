﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotationSpeed = 5.0f;
    public bool usingController = false;

	// Use this for initialization
	void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        // Translate character
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * moveSpeed * Time.deltaTime;

        Vector2 direction;
        float angle = 0f;
        Quaternion rotation;

        if (usingController)
        {
            // Rotate character using right joystick
            direction = new Vector2(Input.GetAxis("RightJoystickHorizontal"), Input.GetAxis("RightJoystickVertical"));
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            if (angle == 0) { rotation = Quaternion.AngleAxis(0, Vector3.forward); }
            else { rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); }
        }
        else
        {
            // Rotate character towards mouse
            direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
