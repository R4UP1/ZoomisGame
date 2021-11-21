using EasyUI.Dialogs;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "TriggerQuestion1":
                DialogUI.Instance
                    .SetQuestion("Sie sind auf den Weg zum Kunden: Welche Dinge sind wichtig zu beachten?")
                    .SetAnswer1("Ich hab meine Zigaretten dabei um nach dem Ausliefern gem�tlich eine zu Rauchen.")
                    .SetAnswer2("Ich achte auf die StVO und beobachte stets den Stra�enverkehr oder auff�llige Autos hinter mir.")
                    .SetAnswer3("Ich habe das Auto vollgetankt um nicht am Stra�enrand stecken zu bleiben und Gefahren ausgesetzt zu sein.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;

            case "TriggerQuestion2":
                DialogUI.Instance
                    .SetQuestion("Wo ist es wohl am besten zum Parken?")
                    .SetAnswer1("�am besten gleich beim McDonalds um die Ecke, damit wir nach dem Auftrag nochschnell einen Burger essen k�nnen.")
                    .SetAnswer2("�am besten so nah wie m�glich bei dem Kunden. Wenn m�glich so, dass man das Autohin und wieder �berpr�fen kann.")
                    .SetAnswer3("�am besten in der N�he einer Baustelle, da durch das laute Arbeiten die Menschendie N�he einer Baustelle eher meiden.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;

            case "TriggerQuestion3":
                DialogUI.Instance
                    .SetQuestion("Nun haben Sie den perfekten Parkplatz gefunden und gehen nun zu dem Kunden zur Anmeldung.")
                    .SetAnswer1("Im Eingangsbereich herumschreien �WO MUSS ICH MIT DEMGELD HIN!!�")
                    .SetAnswer2("Sie suchen den Empfang und begr��en allevorbeigehenden Mitarbeiter.")
                    .SetAnswer3("Sie �bergeben das Geld den n�chstbestenMitarbeiter und schauen, dass Sie so schnell wie m�glich zu den n�chsten Kundenfahren k�nnen.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;

            case "TriggerQuestion4":
                DialogUI.Instance
                    .SetQuestion("Es wird zeit sich wieder auf den Weg zum n�chsten Kunden zu machen, welcher Punkt ist der wichtigste beim Verabschieden?")
                    .SetAnswer1("Man geht nochmal sicher,ob auch wirklich sowohl der Fahrer als auch der Kunde, die ordnungsgem��e�bergabe/�bernahme der Werte unterschrieben haben.")
                    .SetAnswer2("Man steckt 1-2 Euro vonden Safebags f�r Trinkgeld ein.")
                    .SetAnswer3("Man vergewissert sichein letztes Mal, ob man bei dem richtigen Kunden ist.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;
        }










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
