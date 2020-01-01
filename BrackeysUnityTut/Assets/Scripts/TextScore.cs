using System;
using UnityEngine;
using UnityEngine.UI;       //Allows us to write code for the UI

public class TextScore : MonoBehaviour
{
    // Distance travelled along z-axis. Initial value is z = 0, based on position of player in Unity
    public Transform player;
    public Text score;
    public PlayerMovement movement;

    // Update is called once per frame
    void Update()
    {
        //Update only if object not hit
        if (movement.enabled)
        {
            score.text = "Score: " + Math.Floor(player.position.z).ToString();
        }
        
    }
}
