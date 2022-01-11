using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    // OnClickStart is called when "Start Game" button is clicked
    public void OnClickStart()
    {
        SceneManager.LoadScene("GamePage");
    }

    // OnClickHighScore is called when "High Score" button is clicked
    public void OnClickHighScore()
    {
        SceneManager.LoadScene("HighScorePage");
    }

    public void QuitGame()
    {
        Globals.SaveGame();
        Application.Quit();
    }

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Globals.LoadGame();
    }
}
