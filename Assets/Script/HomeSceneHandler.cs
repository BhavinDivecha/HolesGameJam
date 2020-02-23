using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeSceneHandler : MonoBehaviour
{
    public TextMeshProUGUI LevelScene,musicText;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("LevelStatus"))
        {
           
            LevelScene.text = PlayerPrefs.GetString("LevelStatus");
        }
        else
        {
            PlayerPrefs.SetString("LevelStatus", "");
            LevelScene.text = "";
        }
        if(PlayerPrefs.HasKey("Music"))
        {
            musicText.text = "Music : " + PlayerPrefs.GetString("Music");
        }
        else
        {
            musicText.text = "Music : " + PlayerPrefs.GetString("Music","On");
        }
    }
    public void ChangeMusic()
    {
        string str = PlayerPrefs.GetString("Music","On");
        if(str=="On")
        {
            PlayerPrefs.SetString("Music", "Off");
            musicText.text = "Music : " + PlayerPrefs.GetString("Music");
            GameSounds.Instance.Source().mute = true;
        }
        else if (str == "Off")
        {
            PlayerPrefs.SetString("Music", "On");
            musicText.text = "Music : " + PlayerPrefs.GetString("Music");
            GameSounds.Instance.Source().mute = false;
        }
        PlayerPrefs.Save();
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
