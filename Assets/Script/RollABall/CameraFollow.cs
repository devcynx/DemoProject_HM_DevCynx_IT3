using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;       // Ball
    public Vector3 offset;         // Camera offset position
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // Null check lagayen
        if (target == null)
        {
            // Agar ball destroy ho gaya to kuch na karein
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Optional: Look at the ball
        // transform.LookAt(target);
    }
}