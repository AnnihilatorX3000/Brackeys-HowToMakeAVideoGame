using System;
using UnityEngine;
using UnityEngine.UI;       //Allows us to write code for the UI

public class TextScore : MonoBehaviour
{
    // Distance travelled along z-axis. Initial value is z = 0, based on position of player in Unity
    public Transform player;
    public Text score;
    public PlayerMovement movement;

    float zPos;

    // Update is called once per frame
    void Update()
    {
        zPos = player.position.z;

        //Update only if object not hit
        if (movement.enabled)
        {
            //If player misses endTrigger
            if (zPos > 1000)
            {
                score.text = "MISS!";
            }
            else
            {
                score.text = "Distance Left: " + (1000 - Math.Floor(zPos)).ToString();
            }
        }
        else
        {
            score.text = "OW";
        }
        
    }
}
