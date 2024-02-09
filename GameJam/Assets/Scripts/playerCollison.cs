using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollison : MonoBehaviour
{
    Vector3 reflectionDirection; 
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves another object with a Rigidbody
        Rigidbody otherRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        if (otherRigidbody != null)
        {
            // Apply the reflection direction to both objects
            GetComponent<Rigidbody>().velocity = reflectionDirection * 10;
            otherRigidbody.velocity = -reflectionDirection * 10;
        }
    }
}