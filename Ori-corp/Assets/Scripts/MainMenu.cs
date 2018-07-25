using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button NewGameButton;
    public Button ContinueButton;
    public Button QuitButton;


	void Start () {
		NewGameButton.onClick.AddListener(NewGame);
        ContinueButton.onClick.AddListener(Continue);
        QuitButton.onClick.AddListener(Quit);
	}

    void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    void Continue()
    {

    }

    void Quit()
    {
        Application.Quit();
    }
}
