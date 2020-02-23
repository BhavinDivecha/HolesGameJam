using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] allLevels;
    public int currentLevel;
    public static GameManager manager;

    private void Awake()
    {
        manager = null;
        manager = this;
        if(PlayerPrefs.HasKey("CurrentLevel"))
        {
            currentLevel = PlayerPrefs.GetInt("CurrentLevel");
        }
        else
        {
            currentLevel = PlayerPrefs.GetInt("CurrentLevel",0);
        }
        if(currentLevel>=allLevels.Length)
        {
            PlayerPrefs.SetString("LevelStatus", "All Level Clear");
            SceneManager.LoadScene(0);
        }
        for(int i=0;i<allLevels.Length;i++)
        {
            allLevels[i].name = "Level_" + (i + 1);
        }
        for(int i=0;i<allLevels.Length;i++)
        {
            if(i==currentLevel)
            allLevels[i].SetActive(true);
            else
            allLevels[i].SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int home()
    {
        return 0;
    }
    public int Level()
    {
        return 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
