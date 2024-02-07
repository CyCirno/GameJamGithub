using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody leftArm;
    public Rigidbody rightArm;


    public float speed = 5f; // Adjust the speed of movement
    public float jumpForce = 10f; // Adjust the force of the jump
    private bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player is on the ground
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;// * Time.deltaTime;
        rb.AddForce(movement, ForceMode.Acceleration);
        //transform.Translate(movement);

        // Throwin hands
        //Vector3 leftArm = new Vector3


        // Player jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            Debug.Log("Player is grounded");
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
