using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] 
    private string gameOverSceneName = "game over"; // Nom de votre scène Game Over

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with an obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collision avec un obstacle détecté!");
            LoadGameOverScene();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Alternative detection method if you're using triggers instead of collisions
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Trigger avec un obstacle détecté!");
            LoadGameOverScene();
        }
    }

    void LoadGameOverScene()
    {
        // Charger la scène Game Over
        SceneManager.LoadScene(gameOverSceneName);
    }
}