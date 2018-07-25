using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CommanderDialogue : MonoBehaviour
{

    public GameObject CommanderDialoguePanel;
    public Text CommanderText;

    public GameObject NextTextButtonPanel;
    public Button NextTextButton;

    public GameObject AnswersButtonsPanel;
    public Button Answer1Button;
    public Button Answer2Button;
    

    private IEnumerator _textCoroutine;
    public string Changer;
    private string _text;

    void Start()
    {
        Answer1Button.onClick.AddListener(OffDialogue);
        Answer2Button.onClick.AddListener(OffDialogue);
        AnswersButtonsPanel.SetActive(false);
        NextTextButton.onClick.AddListener(TextChanger);
        CommanderText.text = null;
        _text = null;
    }

    void Update()
    {
        _textCoroutine.MoveNext();     
    }

    public void TextChanger()
    {
        if (Changer == "Start")
        {          
            _text = "Добро пожаловать командир. Я бывший главнокомандующий главного блока ОРИ.";
            Changer = "2";
        }
        else if (Changer == "2")
        {
           CommanderText.text = null;
            _text =
                ("Мы занимаеся обеспечение безопасности окружающих от инопланетян, а так же обеспечением безопасности инопланетян от самих себя."
                );
            Changer = "3";
        }
        else if (Changer == "3")
        {
            CommanderText.text = null;
            _text =
                ("Бывал тут раньше? Если нет, то могу устроить тебе экскурсию."
                );
            NextTextButtonPanel.SetActive(false);
            AnswersButtonsPanel.SetActive(true);
            var text = Answer1Button.GetComponentInChildren<Text>();
            text.text = "Да";
            text = Answer2Button.GetComponentInChildren<Text>();
            text.text = "Нет (не поможет)";
        }
        _textCoroutine = TextCoroutine(_text);
    }

    void OffDialogue()
    {
        CommanderDialoguePanel.SetActive(false);
    }

    IEnumerator TextCoroutine(string text)
    {
        foreach (char c in text)
        {
            //print(c);
            CommanderText.text = CommanderText.text + c;
            yield return new WaitForEndOfFrame();
        }
    }
}
