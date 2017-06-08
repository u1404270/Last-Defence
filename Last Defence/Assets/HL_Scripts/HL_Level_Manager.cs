using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HL_Level_Manager : MonoBehaviour
{
    public static HL_Level_Manager instance;
    [Header("Game Phases: Start of Level")]
    public bool bl_Level_Start;
     bool startSetup;

    [Header("Game Phases: Complete Round")]
    public int in_Current_Round;
    public int in_Next_Round_Target = 5;
    public bool bl_Wave_Start;
    public int Max_Pawn = 5;
    public bool Ui_On_Off;

   public  List<GameObject> TotalTargets = new List<GameObject>();

    [Header("Game Phases: Complete Round")]
    public bool bl_Round_Complete;
    public bool bl_Static;



    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        loadLevel();
        if (bl_Level_Start)
        {
            Menu_Manager();
        }
        if (bl_Round_Complete == false && bl_Wave_Start ==true)
        {
            BegineWave();
        }
        if(bl_Level_Start == false)
        {
            WaveManager();
        }

    }
    private void loadLevel()
    {
        if (Application.loadedLevelName == HL_UI_Manager.instance.st_MainGameSceenName && startSetup == false)
        {
            bl_Level_Start = true;
            startSetup = true;
        }
    }

    public void Menu_Manager()
    {
        if (bl_Level_Start == true)
        {
            bl_Static = true;
            HL_PrefabHolder.instance.Select_Cannon_type.SetActive(true);
            HL_PrefabHolder.instance.Background_UI.SetActive(true);
            HL_PrefabHolder.instance.Upgrade_buttons.SetActive(false);
            HL_PrefabHolder.instance.Round_Complete.SetActive(false);
        }
    }
    void BegineWave()
    {
        if (Max_Pawn == 0)
        {
            in_Current_Round++;
            Max_Pawn = 5;
           
        }
        if (in_Current_Round == in_Next_Round_Target)
        {
            bl_Round_Complete = true;
        }
    }
    void WaveManager()
    {
        if (bl_Round_Complete == true && TotalTargets.Count == 0 && Ui_On_Off == false)
        {
            bl_Static = true;
            HL_PrefabHolder.instance.Round_Complete.SetActive(true);
            HL_PrefabHolder.instance.Background_UI.SetActive(true);
            Ui_On_Off = true;
        }
    }
}
