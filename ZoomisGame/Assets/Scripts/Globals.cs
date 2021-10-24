using UnityEngine;

public class Globals : MonoBehaviour
{

    private static int _highScore;

    public static void IncScore()
    {
        Globals._highScore++;
    }

    public static int GetHighScore()
    {
        return _highScore;
    }

}
