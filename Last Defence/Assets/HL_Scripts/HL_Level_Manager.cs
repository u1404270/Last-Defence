using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HL_Level_Manager : MonoBehaviour {

    [Header("Game Phases")]
    public bool bl_Level_Start;
    bool startSetup;
    
    public bool bl_Wave_Start;
    public bool bl_Round_Complete;




    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        loadLevel();

    }
    private void loadLevel()
    {
       if (Application.loadedLevelName == HL_UI_Manager.instance.st_MainGameSceenName && startSetup == false)
        {
            bl_Level_Start = true;
            startSetup = false;   
        }
    }
}
