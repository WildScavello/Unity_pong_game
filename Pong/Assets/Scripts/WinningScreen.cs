using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningScreen : MonoBehaviour
{


    public void Quit()
    {
        Debug.Log("APPLICATION QUIT!");
        Application.Quit();
    }
    public void PlayAgain() 
    {
        SceneManager.LoadScene("MainMenu");
    }

}
