using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody leftArm;
    public Rigidbody rightArm;
    public Rigidbody leftHip;
    public Rigidbody rightHip;


    public float speed = 5f; // Adjust the speed of movement
    public float jumpForce = 10f; // Adjust the force of the jump
    public float armSpeed = 5f;
    public bool isGrounded; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;// * Time.deltaTime;
        rb.AddForce(movement, ForceMode.Acceleration);
        //transform.Translate(movement);

        // Throwin hands

        if (Input.GetKey("e"))
        {
           Vector3 leftArm = new Vector3(1, 0.75f, 0f) * armSpeed;
            rb.AddForce(leftArm, ForceMode.Force);
        }


        // Player jump
        if (isGrounded)
        {
            Debug.Log("Player is grounded");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        leftHip.AddForce(new Vector3(0, jumpForce,0));
        rightHip.AddForce(new Vector3(0, jumpForce, 0));
        isGrounded = false;
    }

 
}
