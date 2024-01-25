using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeMenuUI : MonoBehaviour
{
    //This must be public for the button to access it
    public void BeginButtonClicked()
    {
            SceneManager.LoadScene(1);
    }
}

