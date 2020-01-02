using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;   // Referencing another script

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Ow");
            movement.enabled = false;     // Disables player movement on collision
            FindObjectOfType<GameManager>().LevelLose();
        }
    }
}
