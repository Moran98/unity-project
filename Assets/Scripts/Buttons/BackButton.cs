using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    // return to main menu button from controls
    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
