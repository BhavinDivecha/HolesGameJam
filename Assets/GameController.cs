using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] controllerObject;

    public static GameController controller;
    int currentLevel;
    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        controller = null;
        controller = this;
        currentLevel= PlayerPrefs.GetInt("CurrentLevel");
        LoadGameObject(0);
    }
    public void LoadHomeScene()
    {
        SceneManager.LoadScene(GameManager.manager.home());
    }
    public void LoadNextLevel()
    {
        currentLevel++;
        PlayerPrefs.SetInt("CurrentLevel",currentLevel);
        SceneManager.LoadScene(GameManager.manager.Level());
    }
    public void LoadGameObject(int objNo)
    {
        for(int i=0;i<controllerObject.Length;i++)
        {
            if(i == objNo)
            {
                controllerObject[i].SetActive(true);
            }
            else
            {
                controllerObject[i].SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
