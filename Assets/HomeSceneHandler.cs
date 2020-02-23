using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeSceneHandler : MonoBehaviour
{
    public TextMeshProUGUI LevelScene;
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
