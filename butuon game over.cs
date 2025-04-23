using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Game"); // Relance le jeu
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu"); // Retour au menu
    }
}
