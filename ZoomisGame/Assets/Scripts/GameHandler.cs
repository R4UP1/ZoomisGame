using EasyUI.Dialogs;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TriggerMe")
        {
            DialogUI.Instance
                .SetTitle("Frage")
                .SetMessage("Hier steht eine Frage?")
                .SetButtonColor(DialogButtonColor.Blue)
                .OnClose(
                    () => Restart()
                ).Show();
            Pause();
        }

    }

    void Pause()
    {
        Time.timeScale = 0;

    }

    void Restart()
    {
        Time.timeScale = 1;
    }

}
