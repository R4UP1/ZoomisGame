using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{

    private static int _highScore;
    private static int _score;
    public static readonly List<(string, int)> ScoreProtocol = new List<(string, int)>();

    public static void IncScore()
    {
        _score++;
    }
    
    public static void IncScore(string answer, int score)
    {
        _score += score;
        ScoreProtocol.Add((answer, score));
    }

    public static void SetHighScore(int score)
    {
        _highScore = score;
    }

    public static int GetScore()
    {
        return _score;
    }

    public static int GetHighScore()
    {
        return _highScore;
    }

    public static void SaveGame()
    {
        PlayerPrefs.SetInt("Score", GetHighScore());
    }

    public static void LoadGame()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            SetHighScore(PlayerPrefs.GetInt("Score"));
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
        _score = 0;
        ScoreProtocol.Clear();
    }

    public static string GetProtocolString()
    {
        var s = "";
        foreach ((string, int) tuple in ScoreProtocol)
        {
            s += tuple.Item1 + " Points: " + tuple.Item2 + "\n";
        }

        return s;
    }
}
