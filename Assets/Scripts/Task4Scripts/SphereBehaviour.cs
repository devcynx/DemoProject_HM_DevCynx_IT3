using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    public AudioSource touchsound;
    public float keyinput;
    void Start()
    {
        touchsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 7, ForceMode.VelocityChange);
        }
        keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().linearVelocity = new Vector3(keyinput, GetComponent<Rigidbody>().linearVelocity.y, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("candy"))
            touchsound.Play();
    }
}
