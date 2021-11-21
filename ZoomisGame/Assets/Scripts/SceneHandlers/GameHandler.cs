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
                    .SetAnswer1("Ich hab meine Zigaretten dabei um nach dem Ausliefern gemütlich eine zu Rauchen.")
                    .SetAnswer2("Ich achte auf die StVO und beobachte stets den Straßenverkehr oder auffällige Autos hinter mir.")
                    .SetAnswer3("Ich habe das Auto vollgetankt um nicht am Straßenrand stecken zu bleiben und Gefahren ausgesetzt zu sein.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;

            case "TriggerQuestion2":
                DialogUI.Instance
                    .SetQuestion("Wo ist es wohl am besten zum Parken?")
                    .SetAnswer1("…am besten gleich beim McDonalds um die Ecke, damit wir nach dem Auftrag nochschnell einen Burger essen können.")
                    .SetAnswer2("…am besten so nah wie möglich bei dem Kunden. Wenn möglich so, dass man das Autohin und wieder überprüfen kann.")
                    .SetAnswer3("…am besten in der Nähe einer Baustelle, da durch das laute Arbeiten die Menschendie Nähe einer Baustelle eher meiden.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;

            case "TriggerQuestion3":
                DialogUI.Instance
                    .SetQuestion("Nun haben Sie den perfekten Parkplatz gefunden und gehen nun zu dem Kunden zur Anmeldung.")
                    .SetAnswer1("Im Eingangsbereich herumschreien „WO MUSS ICH MIT DEMGELD HIN!!“")
                    .SetAnswer2("Sie suchen den Empfang und begrüßen allevorbeigehenden Mitarbeiter.")
                    .SetAnswer3("Sie übergeben das Geld den nächstbestenMitarbeiter und schauen, dass Sie so schnell wie möglich zu den nächsten Kundenfahren können.")
                    .OnClose(
                        () => Restart()
                    ).Show();
                Pause();
                break;

            case "TriggerQuestion4":
                DialogUI.Instance
                    .SetQuestion("Es wird zeit sich wieder auf den Weg zum nächsten Kunden zu machen, welcher Punkt ist der wichtigste beim Verabschieden?")
                    .SetAnswer1("Man geht nochmal sicher,ob auch wirklich sowohl der Fahrer als auch der Kunde, die ordnungsgemäßeÜbergabe/Übernahme der Werte unterschrieben haben.")
                    .SetAnswer2("Man steckt 1-2 Euro vonden Safebags für Trinkgeld ein.")
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
