using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadCreditScene()
    {
        SceneManager.LoadScene("Credit");
    }
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
