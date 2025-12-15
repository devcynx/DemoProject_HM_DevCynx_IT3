//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   public GameObject pauseUI;
    public void OnRestartPress() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void OnResumePress()
    {
        pauseUI.SetActive(false);
    }
    public void OnGameExit()
    {
        Application.Quit();  
    }
    public void OnEnterPause()
    {
        pauseUI.SetActive(true);
    }
}
