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

    // Update is called once per frame
    void Update()
    {

    }
    
    void FixedUpdate()
    {
        //Always moving forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Player movement - not the most efficient way
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
