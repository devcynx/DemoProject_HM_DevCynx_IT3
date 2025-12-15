using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle1"))
        {
            Destroy(gameObject); // Player / Ball destroy
        }
    }

}
