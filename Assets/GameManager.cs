using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //To restart the scene

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

   
    public void CompleteLevel()
    {
        
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            // Restart game with a delay of 2f using Invoke(method(), delayTime);
            Invoke("RestartGame", 2f);
        }
    }

    void RestartGame()
    {
        // Loads our currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

