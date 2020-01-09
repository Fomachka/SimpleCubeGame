using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo"
    void OnCollisionEnter(Collision collisionInfo)
    {
        //if there's collision with "Obstacle" stop player's movement
        if(collisionInfo.collider.name == "Obstacle")
        {
            
            movement.enabled = false;  // Disable the players movement
            FindObjectOfType<GameManager>().EndGame(); // Accesses GameManager class and prints out "GAME OVER"
        }
    }
}
