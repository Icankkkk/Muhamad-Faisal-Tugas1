using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void playGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void exitGame()
    {
        Debug.Log("Quit Game"!);
        Application.Quit();
    }
}
