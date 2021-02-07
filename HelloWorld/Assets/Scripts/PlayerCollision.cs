﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    // Stop player movement on collision
    public PlayerMovement movement;

    // Specify method for when object collides with something
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("We hit an obstacle!");
        }
        // Print message to console
        //Debug.Log(collisionInfo.collider.name);
    }
}