﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMovement : MonoBehaviour
{
    public PlayerMovement movement; // A reference to our PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.CompareTag("Ground"))
        {
            movement.enabled = false; // Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.CompareTag("Goal"))
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}