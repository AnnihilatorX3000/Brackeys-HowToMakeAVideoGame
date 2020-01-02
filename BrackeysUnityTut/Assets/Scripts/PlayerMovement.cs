using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;    //For referencing components of Player gameobject
    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Initialised");
    }
    
    void FixedUpdate()
    {
        //Always moving forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Player movement - not the most efficient way
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Check if player has fallen over edge
        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().LevelLose();
        }
    }
}
