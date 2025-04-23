using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Virus")) // Si le joueur touche un virus
        {
            SceneManager.LoadScene("GameOver"); // Aller à la scène Game Over
        }
    }
}
