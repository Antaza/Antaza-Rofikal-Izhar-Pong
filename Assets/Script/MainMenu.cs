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

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    // Memunculkan log debug ketika ditekan
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    // Keluar dari game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
