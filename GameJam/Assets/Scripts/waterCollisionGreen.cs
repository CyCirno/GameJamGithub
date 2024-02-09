using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waterCollisionGreen : MonoBehaviour
{

    private bool isColliding = false;
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a plane
        if (collision.collider.CompareTag("Water"))
        {
            // Do something when player collides with the plane
            SceneManager.LoadScene(3);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (!isColliding && other.CompareTag("Water")) 
        {
            isColliding = true;

            Debug.Log("hit");
        }
    }*/
}
