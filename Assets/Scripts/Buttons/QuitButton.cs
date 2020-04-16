using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    // quit method used to exit to main menu
    public void quit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // start option brings us to the first scene of the game
    public void start()
    {
        SceneManager.LoadScene("Game1");
    }
}
