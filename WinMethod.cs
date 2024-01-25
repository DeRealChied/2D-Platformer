using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMethod : MonoBehaviour
{
    // Reference to the player's ScoreManager script
    public ScoreManager scoreManager;

    // Name of the scene to load when the player wins
    public string winScreenSceneName = "Win";

    // Update is called once per frame
    void Update()
    {
        // Check if the player's score is 4
        if (scoreManager != null && scoreManager.score == 4)
        {
            // Call a method to handle the win condition
            HandleWinCondition();
        }
    }

    private void HandleWinCondition()
    {
        print($"shshd");
        // Load the win screen scene
        SceneManager.LoadScene(winScreenSceneName);
    }
}
