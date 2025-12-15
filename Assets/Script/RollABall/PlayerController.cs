using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.constraints = RigidbodyConstraints.FreezeRotationX |
                         RigidbodyConstraints.FreezeRotationZ;
    }

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            movement += Vector3.up;

        if (Input.GetKey(KeyCode.RightArrow))
            movement += Vector3.right;

        if (Input.GetKey(KeyCode.LeftArrow))
            movement += Vector3.left;

        // Normalize + apply speed
        movement = movement.normalized * speed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + movement);
    }
    void FixedUpdate()
    {
        if (!rb.useGravity)
            rb.useGravity = true;

        if (rb.isKinematic)
            rb.isKinematic = false;
    }       
}
