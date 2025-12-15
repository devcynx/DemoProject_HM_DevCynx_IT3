using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public GameObject gameOverText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          //  Debug.Log("FINISH LINE HIT");

            if (gameOverText != null)
                gameOverText.SetActive(true);

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
            }
        }
    }
}
