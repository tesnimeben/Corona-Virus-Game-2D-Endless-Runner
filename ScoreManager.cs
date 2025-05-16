using UnityEngine;
using TMPro; // ✅ Importer le namespace pour TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // ✅ Remplacer Text par TextMeshProUGUI
    public float score;               // Le score actuel
    public float scoreRate = 1f;      // Points par seconde

    private bool isScoring = true;

    void Update()
    {
        if (isScoring)
        {
            score += scoreRate * Time.deltaTime;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }

    public void StopScoring()
    {
        isScoring = false;
    }

    public void StartScoring()
    {
        isScoring = true;
    }

    public int GetFinalScore()
    {
        return Mathf.FloorToInt(score);
    }
}
