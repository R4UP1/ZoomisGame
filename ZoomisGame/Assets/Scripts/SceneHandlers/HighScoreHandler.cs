using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreHandler : MonoBehaviour
{

    [SerializeField] private Text score;
    [SerializeField] private Text feedback;

    // Update is called once per frame
    private void Update()
    {
        score.text = Globals.GetScore().ToString();
        feedback.text = Globals.GetProtocolString();
    }

    // OnClickResetScore is called when "Reset Score" button is clicked
    public void OnClickResetScore()
    {
        Globals.ResetGame();
    }

    // OnClickBack is called when "Back" button is clicked
    public void OnClickBack()
    {
        SceneManager.LoadScene("MainMenuPage");
    }

    // OnClickBack is called when "Back" button is clicked
    public void OnClickDebug()
    {
        Globals.IncScore();
    }

}
