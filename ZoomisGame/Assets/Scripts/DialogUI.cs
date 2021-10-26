using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

namespace EasyUI.Dialogs {

	public class Dialog {
		public string Question = "Frage?";
		public string Answer1 = "Antwort 1";
		public string Answer2 = "Antwort 2";
		public string Answer3 = "Antwort 3";
		public string Answer4 = "Antwort 4";
		public UnityAction OnClose = null;
	}

	public class DialogUI : MonoBehaviour {
		[SerializeField] GameObject canvas;
		[SerializeField] Text questionUIText;
		[SerializeField] Button answer1Button;
		[SerializeField] Button answer2Button;
		[SerializeField] Button answer3Button;
		[SerializeField] Button answer4Button;

		Image answer1ButtonImage;
		Image answer2ButtonImage;
		Image answer3ButtonImage;
		Image answer4ButtonImage;

		Text answer1ButtonText;
		Text answer2ButtonText;
		Text answer3ButtonText;
		Text answer4ButtonText;

        CanvasGroup canvasGroup;

		[Space ( 20f )]

		Queue<Dialog> dialogsQueue = new Queue<Dialog> ( );
		Dialog dialog = new Dialog ( );
		Dialog tempDialog;

		[HideInInspector] public bool IsActive = false;

		//Singleton pattern
		public static DialogUI Instance;



		void Awake ( ) {
			Instance = this;

			answer1ButtonImage = answer1Button.GetComponent <Image> ( );
			answer2ButtonImage = answer2Button.GetComponent <Image> ( );
			answer3ButtonImage = answer3Button.GetComponent <Image> ( );
			answer4ButtonImage = answer4Button.GetComponent <Image> ( );

			answer1ButtonText = answer1Button.GetComponentInChildren <Text> ( );
			answer2ButtonText = answer2Button.GetComponentInChildren <Text> ( );
			answer3ButtonText = answer3Button.GetComponentInChildren <Text> ( );
			answer4ButtonText = answer4Button.GetComponentInChildren <Text> ( );

			canvasGroup = canvas.GetComponent <CanvasGroup> ( );

			//Add close event listener
			answer1Button.onClick.RemoveAllListeners();
			answer1Button.onClick.AddListener(ChooseAnswer1);

            answer2Button.onClick.RemoveAllListeners();
            answer2Button.onClick.AddListener(ChooseAnswer2);

            answer3Button.onClick.RemoveAllListeners();
            answer3Button.onClick.AddListener(ChooseAnswer3);

            answer4Button.onClick.RemoveAllListeners();
            answer4Button.onClick.AddListener(ChooseAnswer4);
		}


        public DialogUI SetQuestion ( string question ) {
			dialog.Question = question;
			return Instance;
		}


        public DialogUI SetAnswer1(string answer)
        {
            dialog.Answer1 = answer;
            return Instance;
        }


        public DialogUI SetAnswer2(string answer)
        {
            dialog.Answer2 = answer;
            return Instance;
        }


        public DialogUI SetAnswer3(string answer)
        {
            dialog.Answer3 = answer;
            return Instance;
        }


        public DialogUI SetAnswer4(string answer)
        {
            dialog.Answer4 = answer;
            return Instance;
        }
        
        
        public DialogUI OnClose ( UnityAction action ) {
			dialog.OnClose = action;
			return Instance;
		}

		//-------------------------------------
		
		public void Show ( ) {
			dialogsQueue.Enqueue ( dialog );
			//Reset Dialog
			dialog = new Dialog ( );

			if ( !IsActive )
				ShowNextDialog ( );
		}


		void ShowNextDialog ( ) {
			tempDialog = dialogsQueue.Dequeue ( );
			
			questionUIText.text = tempDialog.Question;
			answer1ButtonText.text = tempDialog.Answer1.ToUpper ( );
			answer2ButtonText.text = tempDialog.Answer2.ToUpper ( );
			answer3ButtonText.text = tempDialog.Answer3.ToUpper ( );
			answer4ButtonText.text = tempDialog.Answer4.ToUpper ( );

			canvas.SetActive ( true );
			IsActive = true;
		}


		// Hide dialog
		public void Hide ( ) {
			canvas.SetActive ( false );
			IsActive = false;

			// Invoke OnClose Event
			if ( tempDialog.OnClose != null )
				tempDialog.OnClose.Invoke ( );

			StopAllCoroutines ( );

			if ( dialogsQueue.Count != 0 )
				ShowNextDialog ( );
		}

        //-------------------------------------

        public void ChooseAnswer1()
        {
			// Hier passiert was...
			Hide();
        }


        public void ChooseAnswer2()
        {
            // Hier passiert was...
            Hide();
        }


        public void ChooseAnswer3()
        {
            // Hier passiert was...
            Hide();
        }


        public void ChooseAnswer4()
        {
            // Hier passiert was...
            Hide();
        }
	}

}
