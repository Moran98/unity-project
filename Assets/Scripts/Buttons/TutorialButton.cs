using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void viewTutorial()
    {
        // load tutorial scene
        SceneManager.LoadScene("GameTutorial");
    }
}
