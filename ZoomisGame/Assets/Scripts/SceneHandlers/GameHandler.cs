using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneHandlers
{
    public class GameHandler : MonoBehaviour
    {
        private static GameObject _q1;
        private static GameObject _q2;
        private static GameObject _q3;
        private static GameObject _q4;

        private static GameObject _w1;
        private static GameObject _w2;
        private static GameObject _w4;

        private static GameObject _goal;

        private void Awake()
        {
            if (_goal == null)
            {
                _q1 = GameObject.Find("TriggerQuestion1");
                _q2 = GameObject.Find("TriggerQuestion2");
                _q3 = GameObject.Find("TriggerQuestion3");
                _q4 = GameObject.Find("TriggerQuestion4");

                _w1 = GameObject.Find("TriggerQuestion1_Wrong");
                _w2 = GameObject.Find("TriggerQuestion2_Wrong");
                _w4 = GameObject.Find("TriggerQuestion4_Wrong");


                _goal = GameObject.Find("TriggerGoal");
                
                SetFinishedState(false);
                PauseGame();
            }
        }

        private void Update()
        {
            UpdateFinishedState();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            switch (collision.gameObject.name)
            {
                case "TriggerQuestion1":
                    ShowQuestion1Popup();
                    break;

                case "TriggerQuestion1_Wrong":
                    ShowQuestion1PopupWrong();
                    break;

                case "TriggerQuestion2":
                    ShowQuestion2Popup();
                    break;

                case "TriggerQuestion2_Wrong":
                    ShowQuestion2PopupWrong();
                    break;

                case "TriggerQuestion3":
                    ShowQuestion3Popup();
                    break;

                case "TriggerQuestion4":
                    ShowQuestion4Popup();
                    break;

                case "TriggerQuestion4_Wrong":
                    ShowQuestion4PopupWrong();
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
                "Ich hab meine Zigaretten dabei um nach dem Ausliefern gemütlich eine zu Rauchen.";
            dialog.answer2ButtonText.text =
                "Ich achte auf die StVO und beobachte stets den Straßenverkehr oder auffällige Autos hinter mir.";
            dialog.answer3ButtonText.text =
                "Ich habe das Auto voll getankt um nicht am Straßenrand stecken zu bleiben und Gefahren ausgesetzt zu sein.";

            dialog.Answer1Action = () =>
            {
                Globals.IncScore(dialog.answer1ButtonText.text, 0);
                SetQuestion1State(false);
            };
            dialog.Answer2Action = () =>
            {
                Globals.IncScore(dialog.answer2ButtonText.text, 3);
                SetQuestion1State(false);
            };
            dialog.Answer3Action = () =>
            {
                Globals.IncScore(dialog.answer3ButtonText.text, 2);
                SetQuestion1State(false);
            };

            dialog.Show();
        }

        private static void ShowQuestion1PopupWrong()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text = "Sie sind auf den Weg zum Kunden: Welche Dinge sind wichtig zu beachten?";

            dialog.answer1ButtonText.text =
                "Ich hab meine Zigaretten dabei um nach dem Ausliefern gemütlich eine zu Rauchen.";
            dialog.answer2ButtonText.text =
                "Ich achte auf die StVO und beobachte stets den Straßenverkehr oder auffällige Autos hinter mir.";
            dialog.answer3ButtonText.text =
                "Ich habe das Auto voll getankt um nicht am Straßenrand stecken zu bleiben und Gefahren ausgesetzt zu sein.";

            dialog.Answer1Action = () =>
            {
                Globals.IncScore(dialog.answer1ButtonText.text + "(Falsch geparkt!)", 0);
                SetQuestion1State(false);
            };
            dialog.Answer2Action = () => { SetQuestion1State(false); };
            dialog.Answer3Action = () => { SetQuestion1State(false); };

            dialog.Show();
        }

        private static void ShowQuestion2Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text = "Wo ist es wohl am besten zum Parken?";

            dialog.answer1ButtonText.text =
                "Am besten gleich beim McDonalds um die Ecke, damit wir nach dem Auftrag noch schnell einen Burger essen können.";
            dialog.answer2ButtonText.text =
                "Am besten so nah wie möglich bei dem Kunden. Wenn möglich so, dass man das Auto hin und wieder überprüfen kann.";
            dialog.answer3ButtonText.text =
                "Am besten in der Nähe einer Baustelle, da durch das laute Arbeiten die Menschen die Nähe einer Baustelle eher meiden.";

            dialog.Answer1Action = () =>
            {
                Globals.IncScore(dialog.answer1ButtonText.text, 0);
                SetQuestion2State(false);
            };
            dialog.Answer2Action = () =>
            {
                Globals.IncScore(dialog.answer2ButtonText.text, 3);
                SetQuestion2State(false);
            };
            dialog.Answer3Action = () =>
            {
                Globals.IncScore(dialog.answer3ButtonText.text, 2);
                SetQuestion2State(false);
            };

            dialog.Show();
        }

        private static void ShowQuestion2PopupWrong()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text = "Wo ist es wohl am besten zum Parken?";

            dialog.answer1ButtonText.text =
                "Am besten gleich beim McDonalds um die Ecke, damit wir nach dem Auftrag noch schnell einen Burger essen können.";
            dialog.answer2ButtonText.text =
                "Am besten so nah wie möglich bei dem Kunden. Wenn möglich so, dass man das Auto hin und wieder überprüfen kann.";
            dialog.answer3ButtonText.text =
                "Am besten in der Nähe einer Baustelle, da durch das laute Arbeiten die Menschen die Nähe einer Baustelle eher meiden.";

            dialog.Answer1Action = () => { SetQuestion2State(false); };
            dialog.Answer2Action = () => { SetQuestion2State(false); };
            dialog.Answer3Action = () => { SetQuestion2State(false); };

            dialog.Show();
        }

        private static void ShowQuestion3Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text =
                "Nun haben Sie den perfekten Parkplatz gefunden und gehen nun zu dem Kunden zur Anmeldung.";
            dialog.answer1ButtonText.text = "Im Eingangsbereich herumschreien 'WO MUSS ICH MIT DEM GELD HIN!!'";
            dialog.answer2ButtonText.text = "Sie suchen den Empfang und begrüßen alle vorbeigehenden Mitarbeiter.";
            dialog.answer3ButtonText.text =
                "Sie übergeben das Geld den nächstbesten Mitarbeiter und schauen, dass Sie so schnell wie möglich zu den nächsten Kundenfahren können.";

            dialog.Answer1Action = () =>
            {
                Globals.IncScore(dialog.answer1ButtonText.text, 0);
                SetQuestion3State(false);
            };
            dialog.Answer2Action = () =>
            {
                Globals.IncScore(dialog.answer2ButtonText.text, 3);
                SetQuestion3State(false);
            };
            dialog.Answer3Action = () =>
            {
                Globals.IncScore(dialog.answer3ButtonText.text, 0);
                SetQuestion3State(false);
            };

            dialog.Show();
        }

        private static void ShowQuestion4Popup()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text =
                "Es wird zeit sich wieder auf den Weg zum nächsten Kunden zu machen, welcher Punkt ist der wichtigste beim Verabschieden?";

            dialog.answer1ButtonText.text =
                "Man geht nochmal sicher, ob auch wirklich sowohl der Fahrer als auch der Kunde, die ordnungsgemäße Übergabe/Übernahme der Werte unterschrieben haben.";
            dialog.answer2ButtonText.text = "Man steckt 1-2 Euro von den Safebags für Trinkgeld ein.";
            dialog.answer3ButtonText.text =
                "Man vergewissert sich ein letztes Mal, ob man bei dem richtigen Kunden ist.";

            dialog.Answer1Action = () =>
            {
                Globals.IncScore(dialog.answer1ButtonText.text, 3);
                SetQuestion4State(false);
            };
            dialog.Answer2Action = () =>
            {
                Globals.IncScore(dialog.answer2ButtonText.text, 0);
                SetQuestion4State(false);
            };
            dialog.Answer3Action = () =>
            {
                Globals.IncScore(dialog.answer3ButtonText.text, 1);
                SetQuestion4State(false);
            };

            dialog.Show();
        }

        private static void ShowQuestion4PopupWrong()
        {
            var dialog = DialogPopup.Instance;

            dialog.questionText.text =
                "Es wird zeit sich wieder auf den Weg zum nächsten Kunden zu machen, welcher Punkt ist der wichtigste beim Verabschieden?";

            dialog.answer1ButtonText.text =
                "Man geht nochmal sicher, ob auch wirklich sowohl der Fahrer als auch der Kunde, die ordnungsgemäße Übergabe/Übernahme der Werte unterschrieben haben.";
            dialog.answer2ButtonText.text = "Man steckt 1-2 Euro von den Safebags für Trinkgeld ein.";
            dialog.answer3ButtonText.text =
                "Man vergewissert sich ein letztes Mal, ob man bei dem richtigen Kunden ist.";

            dialog.Answer1Action = () => { SetQuestion4State(false); };
            dialog.Answer2Action = () => { SetQuestion4State(false); };
            dialog.Answer3Action = () => { SetQuestion4State(false); };

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

        public static void CloseTutorial()
        {
            GameObject.Find("TutorialPopup").SetActive(false);
            ResumeToGame();
        }

        // OnClickHighScore is called when "Show Highscore" button is clicked
        public void OnClickHighScore()
        {
            SceneManager.LoadScene("HighScorePage");
            ResumeToGame();
        }

        private static void UpdateFinishedState()
        {
            if (!_q1.activeSelf && !_q2.activeSelf && !_q3.activeSelf && !_q4.activeSelf)
            {
                SetFinishedState(true);
            }
        }

        public static void SetQuestion1State(bool state)
        {
            _q1.SetActive(state);
            _w1.SetActive(state);
            UpdateFinishedState();
        }

        public static void SetQuestion2State(bool state)
        {
            _q2.SetActive(state);
            _w2.SetActive(state);
            UpdateFinishedState();
        }

        public static void SetQuestion3State(bool state)
        {
            _q3.SetActive(state);
            UpdateFinishedState();
        }

        public static void SetQuestion4State(bool state)
        {
            _q4.SetActive(state);
            _w4.SetActive(state);
            UpdateFinishedState();
        }

        public static void SetFinishedState(bool state)
        {
            _goal.SetActive(state);
        }
    }
}