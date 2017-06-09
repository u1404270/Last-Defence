using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HL_UI_Manager : MonoBehaviour {
    public static HL_UI_Manager instance;


    public string st_MainGameSceenName;
    public string st_MainMenuName;


    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Options()
    {

    }
    public void NewGame()
    {
       // Application.LoadLevel(st_MainGameSceenName);
        SceneManager.LoadScene(st_MainGameSceenName);
    }
    public void Continue()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
       // Application.LoadLevel(st_MainMenuName);
        SceneManager.LoadScene(st_MainMenuName);
    }
}
