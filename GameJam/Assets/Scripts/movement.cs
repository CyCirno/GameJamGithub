using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody leftArm;
    public Rigidbody rightArm;
    public Rigidbody leftHip;
    public Rigidbody rightHip;

    public float jumpCooldown = 3;
    public float thrustCooldown = 1.5f;
    public float speed = 5f; // Adjust the speed of movement
    public float jumpForce = 10f; // Adjust the force of the jump
    public float thrustSpeed = 5f;
    private Rigidbody rb;
    private float timeSinceJump = 2;
    private float timeSinceThrust = 1;
    public string horizontalAxis;
    public string verticalAxis;
    public string playerJump;
    public string playerThrust;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timeSinceJump += Time.deltaTime;
        timeSinceThrust += Time.deltaTime;

        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode))) { if (Input.GetKeyDown(kcode)) Debug.Log("KeyCode down: " + kcode); }

        // Player movement
        float horizontalInput = Input.GetAxis(horizontalAxis);
        float verticalInput = Input.GetAxis(verticalAxis);
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;// * Time.deltaTime;
        rb.AddForce(movement, ForceMode.Acceleration);
        //transform.Translate(movement);

        // Throwin hands

        if (Input.GetButton(playerThrust) && timeSinceThrust >= thrustCooldown)
        {
           Vector3 thrustMovement = new Vector3(1f, 0f, 0f) * thrustSpeed;
           rb.AddForce(thrustMovement, ForceMode.Impulse);
           timeSinceThrust = 0;
        }


        // Player jump

        if (Input.GetButtonDown(playerJump) && timeSinceJump >= jumpCooldown)
            {
                Jump();
            }
      
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        timeSinceJump = 0;
        
    }

 
}
