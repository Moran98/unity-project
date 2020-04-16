using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    void Awake()
    {
        // Keeps background audio playing from MainMenu throughout the game
        DontDestroyOnLoad(transform.gameObject);
    }
}
