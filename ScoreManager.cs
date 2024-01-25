using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
        public int score = 0;
        public Text scoreText; // Reference to a UI Text component to display the score

        public void AddScore(int amount)
        {
            score += amount;

            print($"+1 {score}");
            // Update the UI Text to display the updated score
            if (scoreText != null)
            {
                scoreText.text = $"Score: {score}";

            if (score == 4)
            {
                SceneManager.LoadScene(2);
            }
            }
        }
}
