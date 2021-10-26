using EasyUI.Dialogs;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TriggerMe")
        {
            DialogUI.Instance
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
