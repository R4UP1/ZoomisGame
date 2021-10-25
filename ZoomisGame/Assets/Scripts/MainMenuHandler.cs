using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EasyUI.Dialogs;

public class MainMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        Application.Quit();
    }
}
