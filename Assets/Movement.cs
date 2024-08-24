using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float MoveForce = 800f;
    public float sidewaysForce = 500f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // This line pushes the cube forward
        rb.AddForce(0, 0, MoveForce * Time.deltaTime);

        // Is called when the player presses the d button
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        // Is called when the player presses the a button
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
