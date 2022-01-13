using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{

    private static int _highScore;
    public static readonly List<(string, int)> ScoreProtocol = new List<(string, int)>();

    public static void IncScore()
    {
        _highScore++;
    }
    
    public static void IncScore(string answer, int score)
    {
        _highScore += score;
        ScoreProtocol.Add((answer, score));
    }

    public static void SetScore(int newScore)
    {
        _highScore = newScore;
    }

    public static int GetScore()
    {
        return _highScore;
    }

    public static void SaveGame()
    {
        PlayerPrefs.SetInt("Score", GetScore());
    }

    public static void LoadGame()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            SetScore(PlayerPrefs.GetInt("Score"));
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
