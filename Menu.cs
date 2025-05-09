using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); // Change selon ta scène
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
