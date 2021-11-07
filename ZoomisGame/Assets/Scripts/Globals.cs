using UnityEngine;

public class Globals : MonoBehaviour
{

    private static int _highScore;

    public static void IncScore()
    {
        Globals._highScore++;
    }

    public static void SetHighScore(int newScore)
    {
        _highScore = newScore;
    }

    public static int GetHighScore()
    {
        return _highScore;
    }

    public static void SaveGame()
    {
        PlayerPrefs.SetInt("Score", Globals.GetHighScore());
    }

    public static void LoadGame()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            Globals.SetHighScore(PlayerPrefs.GetInt("Score"));
        }
        else
        {
            Debug.Log("There is no save data!");
        }
    }

    public static void ResetGame()
    {
        PlayerPrefs.DeleteKey("Score");
        _highScore = 0;
    }

}
