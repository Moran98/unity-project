using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{

    [SerializeField] private int sceneNum;
    // load the next wave once the user collects all the items
    public void nextWave()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
