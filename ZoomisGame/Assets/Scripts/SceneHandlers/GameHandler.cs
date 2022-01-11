using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneHandlers
{
    public class GameHandler : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            switch (collision.gameObject.name)
            {
                case "TriggerQuestion1":
                    ShowQuestion1Popup();
                    break;

                case "TriggerQuestion2":
                    ShowQuestion2Popup();
                    break;

                case "TriggerQuestion3":
                    ShowQuestion3Popup();
                    break;

                case "TriggerQuestion4":
                    ShowQuestion4Popup();
                    break;

                case "TriggerGoal":
                    ShowVictoryPopup();
                    break;
            }


            if (collision.gameObject.name == "TriggerMe")
            {
            }
        }

        private static void ShowQuestion1Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text = "Sie sind auf den Weg zum Kunden: Welche Dinge sind wichtig zu beachten?";

            dialog.answer1ButtonText.text =
                "Ich hab meine Zigaretten dabei um nach dem Ausliefern gem�tlich eine zu Rauchen.";
            dialog.answer2ButtonText.text =
                "Ich achte auf die StVO und beobachte stets den Stra�enverkehr oder auff�llige Autos hinter mir.";
            dialog.answer3ButtonText.text =
                "Ich habe das Auto vollgetankt um nicht am Stra�enrand stecken zu bleiben und Gefahren ausgesetzt zu sein.";

            dialog.Answer1Action = () => print("Clicked 1!");
            dialog.Answer2Action = () => print("Clicked 2!");
            dialog.Answer3Action = () => print("Clicked 3!");

            dialog.Show();
        }

        private static void ShowQuestion2Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text = "Wo ist es wohl am besten zum Parken?";

            dialog.answer1ButtonText.text =
                "�am besten gleich beim McDonalds um die Ecke, damit wir nach dem Auftrag nochschnell einen Burger essen k�nnen.";
            dialog.answer2ButtonText.text =
                "�am besten so nah wie m�glich bei dem Kunden. Wenn m�glich so, dass man das Autohin und wieder �berpr�fen kann.";
            dialog.answer3ButtonText.text =
                "�am besten in der N�he einer Baustelle, da durch das laute Arbeiten die Menschendie N�he einer Baustelle eher meiden.";

            dialog.Answer1Action = () => print("Clicked 1!");
            dialog.Answer2Action = () => print("Clicked 2!");
            dialog.Answer3Action = () => print("Clicked 3!");

            dialog.Show();
        }

        private static void ShowQuestion3Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text =
                "Nun haben Sie den perfekten Parkplatz gefunden und gehen nun zu dem Kunden zur Anmeldung.";
            dialog.answer1ButtonText.text = "Im Eingangsbereich herumschreien �WO MUSS ICH MIT DEMGELD HIN!!�";
            dialog.answer2ButtonText.text = "Sie suchen den Empfang und begr��en allevorbeigehenden Mitarbeiter.";
            dialog.answer3ButtonText.text =
                "Sie �bergeben das Geld den n�chstbestenMitarbeiter und schauen, dass Sie so schnell wie m�glich zu den n�chsten Kundenfahren k�nnen.";

            dialog.Answer1Action = () => print("Clicked 1!");
            dialog.Answer2Action = () => print("Clicked 2!");
            dialog.Answer3Action = () => print("Clicked 3!");

            dialog.Show();
        }

        private static void ShowQuestion4Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text =
                "Es wird zeit sich wieder auf den Weg zum n�chsten Kunden zu machen, welcher Punkt ist der wichtigste beim Verabschieden?";

            dialog.answer1ButtonText.text =
                "Man geht nochmal sicher,ob auch wirklich sowohl der Fahrer als auch der Kunde, die ordnungsgem��e�bergabe/�bernahme der Werte unterschrieben haben.";
            dialog.answer2ButtonText.text = "Man steckt 1-2 Euro vonden Safebags f�r Trinkgeld ein.";
            dialog.answer3ButtonText.text = "Man vergewissert sichein letztes Mal, ob man bei dem richtigen Kunden ist.";

            dialog.Answer1Action = () => print("Clicked 1!");
            dialog.Answer2Action = () => print("Clicked 2!");
            dialog.Answer3Action = () => print("Clicked 3!");

            dialog.Show();
        }

        private static void ShowVictoryPopup()
        {
            VictoryPopup.Instance.canvas.SetActive(true);
            PauseGame();
        }

        public static void PauseGame()
        {
            Time.timeScale = 0;
        }

        public static void ResumeToGame()
        {
            Time.timeScale = 1;
        }
    
        // OnClickHighScore is called when "Show Highscore" button is clicked
        public void OnClickHighScore()
        {
            SceneManager.LoadScene("HighScorePage");
            ResumeToGame();
        }
    }
}
