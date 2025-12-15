using UnityEngine;

public class FinishingLine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameOverText;  // Reference to UI text

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))   // Ball ka tag Player hona chahiye
        {
            gameOverText.SetActive(true);    // show GAME OVER
            Time.timeScale = 0f;             // stop game (optional)
        }
    }
}
