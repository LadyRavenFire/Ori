using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    void Start()
    {
        StartGameDialogue();
    }

    void StartGameDialogue()
    {
       CommanderDialogue dialogue = gameObject.GetComponent<CommanderDialogue>();

        dialogue.Changer = "Start";
        dialogue.TextChanger();
    }

}
