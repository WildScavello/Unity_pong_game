using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void Quit()
    {
        Debug.Log("APPLICATION QUIT!");
        Application.Quit();
    }
    public void MultiPlayerLevel()
    {
        SceneManager.LoadScene("MultiPlayer");

    }
    public void SinglePlayerLevel()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
    public void ControlLevel()
    {
        SceneManager.LoadScene("Controls");
    }
}
