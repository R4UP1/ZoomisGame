using SceneHandlers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogPopup : MonoBehaviour
{
    [SerializeField] public GameObject canvas;
    [SerializeField] public Text questionText;
    [SerializeField] public Button answer1Button;
    [SerializeField] public Button answer2Button;
    [SerializeField] public Button answer3Button;
    [SerializeField] public Text answer1ButtonText;
    [SerializeField] public Text answer2ButtonText;
    [SerializeField] public Text answer3ButtonText;

    public UnityAction Answer1Action;
    public UnityAction Answer2Action;
    public UnityAction Answer3Action;

    public static DialogPopup Instance;

    //--------------------------------------------------------------------------------------------------------------

    private void Awake()
    {
        Instance = this;

        answer1Button.onClick.RemoveAllListeners();
        answer2Button.onClick.RemoveAllListeners();
        answer3Button.onClick.RemoveAllListeners();

        answer1Button.onClick.AddListener(OnAction1);
        answer2Button.onClick.AddListener(OnAction2);
        answer3Button.onClick.AddListener(OnAction3);
    }

    //--------------------------------------------------------------------------------------------------------------

    private void OnAction1()
    {
        Answer1Action.Invoke();
        Hide();
    }

    private void OnAction2()
    {
        Answer2Action.Invoke();
        Hide();
    }

    private void OnAction3()
    {
        Answer3Action.Invoke();
        Hide();
    }

    //--------------------------------------------------------------------------------------------------------------

    public void Show()
    {
        canvas.SetActive(true);
        GameHandler.PauseGame();
    }

    private void Hide()
    {
        canvas.SetActive(false);
        GameHandler.ResumeToGame();
    }
}
