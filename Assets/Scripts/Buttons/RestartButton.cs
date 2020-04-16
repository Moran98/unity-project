using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    [SerializeField] private int restartSceneNum;

    public void restartScene()
    {
        // game resumes on click depending on option
        // issue with game remaining paused after selecting an option in pause menu but setting timescale solves this issue
        Time.timeScale = 1f;
        SceneManager.LoadScene(restartSceneNum);
    }
}
