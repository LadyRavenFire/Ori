using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CommanderDialogue : MonoBehaviour
{

    public GameObject CommanderDialoguePanel;
    public Text CommanderText;
    public Button NextText;

    private IEnumerator _textCoroutine;
    public string Changer;
    private string _text;

    void Start()
    {
        NextText.onClick.AddListener(TextChanger);
        CommanderText.text = null;
        _text = null;
    }

    void FixedUpdate()
    {
        _textCoroutine.MoveNext();     
    }

    public void TextChanger()
    {
        if (Changer == "Start")
        {          
            _text = "Добро пожаловать командир. Я бывший главнокомандующий главного блока ОРИ.";
            Changer = "Second";
        }
        else if (Changer == "Second")
        {
           CommanderText.text = null;
            _text =
                ("Мы занимаеся обеспечение безопасности окружающих от инопланетян, а так же обеспечением безопасности инопланетян от самих себя."
                );
        }
        _textCoroutine = TextCoroutine(_text);
    }

    IEnumerator TextCoroutine(string text)
    {
        foreach (char c in text)
        {
            //print(c);
            CommanderText.text = CommanderText.text + c;
            yield return new WaitForFixedUpdate();
        }
    }
}
