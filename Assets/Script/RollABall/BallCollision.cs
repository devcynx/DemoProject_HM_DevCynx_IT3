using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle1"))
        {
            Destroy(gameObject); // Player / Ball destroy
        }
    }

}
