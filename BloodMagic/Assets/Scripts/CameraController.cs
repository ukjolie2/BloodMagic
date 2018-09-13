using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object

    public float smoothSpeed = 0.125f;
    // Use this for initialization
    void Start()
    {
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        Vector3 finalPosition = Vector3.Lerp(transform.position, newPosition, smoothSpeed);
        transform.position = finalPosition;
    }
}
