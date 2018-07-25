using UnityEngine;
using UnityEngine.UI;

public class CamerasManager : MonoBehaviour
{

    public Camera[] Cameras;

    public Button MainButton;
    public Button LaboratoryButton;
    public Button FinanceButton;
    public Button SecurityButton;
    public Button WarCenterButton;
    public Button PoliticalButton;

    void Start()
    {
        for (int i = 1; i < Cameras.Length; i++)
        {
            var audio = Cameras[i].GetComponent<AudioListener>();
            audio.enabled = false;
            Cameras[i].enabled = false;
        }

        MainButton.onClick.AddListener(MainButtonClick);
        LaboratoryButton.onClick.AddListener(LaboratoryButtonClick);
        FinanceButton.onClick.AddListener(FinanceButtonClick);
        SecurityButton.onClick.AddListener(SecurityButtonClick);
        WarCenterButton.onClick.AddListener(WarCenterButtonClick);
        PoliticalButton.onClick.AddListener(PoliticalButtonClick);
    }

    void MainButtonClick()
    {
        foreach (var t in Cameras)
        {
            var audio = t.GetComponent<AudioListener>();
            audio.enabled = false;
            t.enabled = false;
        }

        Cameras[0].enabled = true;
        var audio1 = Cameras[0].GetComponent<AudioListener>();
        audio1.enabled = false;
    }

    void LaboratoryButtonClick()
    {
        foreach (var t in Cameras)
        {
            var audio = t.GetComponent<AudioListener>();
            audio.enabled = false;
            t.enabled = false;
        }

        Cameras[1].enabled = true;
        var audio1 = Cameras[1].GetComponent<AudioListener>();
        audio1.enabled = false;
    }

    void FinanceButtonClick()
    {
        foreach (var t in Cameras)
        {
            var audio = t.GetComponent<AudioListener>();
            audio.enabled = false;
            t.enabled = false;
        }

        Cameras[2].enabled = true;
        var audio1 = Cameras[2].GetComponent<AudioListener>();
        audio1.enabled = false;
    }

    void SecurityButtonClick()
    {
        foreach (var t in Cameras)
        {
            var audio = t.GetComponent<AudioListener>();
            audio.enabled = false;
            t.enabled = false;
        }

        Cameras[3].enabled = true;
        var audio1 = Cameras[3].GetComponent<AudioListener>();
        audio1.enabled = false;
    }

    void WarCenterButtonClick()
    {
        foreach (var t in Cameras)
        {
            var audio = t.GetComponent<AudioListener>();
            audio.enabled = false;
            t.enabled = false;
        }

        Cameras[4].enabled = true;
        var audio1 = Cameras[4].GetComponent<AudioListener>();
        audio1.enabled = false;
    }

    void PoliticalButtonClick()
    {
        foreach (var t in Cameras)
        {
            var audio = t.GetComponent<AudioListener>();
            audio.enabled = false;
            t.enabled = false;
        }

        Cameras[5].enabled = true;
        var audio1 = Cameras[5].GetComponent<AudioListener>();
        audio1.enabled = false;
    }

   
}
