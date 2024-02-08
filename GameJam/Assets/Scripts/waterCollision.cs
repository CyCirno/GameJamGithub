using UnityEngine;

public class waterCollision : MonoBehaviour
{
    public PlayerController playerController;

    public LayerMask waterLayer;

    private void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == waterLayer)
        {
            
        }
    }
}
