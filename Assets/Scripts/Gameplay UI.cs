using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Captain");
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RequestParlay()
    {
        SceneManager.LoadScene("CrosSworder");
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the game (only works on build)
        UnityEditor.EditorApplication.isPlaying = false; //Quits but returns to unity editor
    }
}
