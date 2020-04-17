using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    // variables
    public static bool GameIsPaused = false;
    private GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        // 'ESC' to activate pause menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        // remove pause menu
        pauseMenuUI.SetActive(false);
        // fixes bug that requires a second press of 'ESC' to resume
        Time.timeScale = 1f;
        // game no longer paused 
        GameIsPaused = false;
    }

    void Pause()
    {
        // activate pause menu
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        // game is paused 
        GameIsPaused = true;
    }
}
