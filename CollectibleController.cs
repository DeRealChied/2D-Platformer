using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleController : MonoBehaviour
{
    // You can customize the score increase amount
    public int scoreIncreaseAmount = 1;
    ScoreManager scoreManager;

    private void Start()
    {
        GameObject sb = GameObject.Find("ScoreBoard");
        scoreManager = sb.GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object that touched the collectible is the player
        if (collision.CompareTag("Player"))
        {
            // Call a function to handle collecting the item
            //    CollectItem(collision.gameObject);
            CollectItemAndIncreaseScore();
        }
    }
    public void CollectItemAndIncreaseScore()
    {
        Destroy(gameObject);
        // Assuming you have a ScoreManager reference
        if (scoreManager != null)
        {
            // Call the AddScore method with the desired amount
            scoreManager.AddScore(scoreIncreaseAmount); // You can pass any desired score increase amount
        }
        else
        {
            Debug.LogError("ScoreManager reference is missing!");
        }
    }
}