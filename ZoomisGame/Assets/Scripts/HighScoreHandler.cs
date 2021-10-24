using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreHandler : MonoBehaviour
{

    [SerializeField]
    private Text _score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _score.text = Globals.GetHighScore().ToString();
    }

    // OnClickBack is called when "Back" button is clicked
    public void OnClickBack()
    {
        SceneManager.LoadScene("MainMenuPage");
    }
}
