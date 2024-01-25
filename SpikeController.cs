using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object that touched the spikes is the player
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}

