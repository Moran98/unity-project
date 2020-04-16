using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsButton : MonoBehaviour
{
    // load Controls menu UI
    public void viewControls()
    {

        SceneManager.LoadScene("Controls");
    }
}
