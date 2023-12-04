using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Berganti Scene ke Scene "Pong"
    public void StartGame()
    {
        SceneManager.LoadScene("Pong");
        Debug.Log("Created by Antaza Rofikal Izhar");
    }
    
    // Memunculkan log debug ketika ditekan
    public void Credit()
    {
        Debug.Log("Created by Antaza Rofikal Izhar");
    }

    // Keluar dari game
    public void QuitGame()
    {
        Debug.Log("Quit Game");
    }
}
