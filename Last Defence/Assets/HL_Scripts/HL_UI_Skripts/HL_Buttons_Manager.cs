using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HL_Buttons_Manager : MonoBehaviour {
    public string st_MainMenuName;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BeineGame()
    {
        HL_Level_Manager.instance.bl_Static = false;
        HL_Level_Manager manager = GameObject.Find("Game Manager").GetComponent<HL_Level_Manager>();
        manager.bl_Level_Start = false;
        manager.bl_Wave_Start = true;
        HL_PrefabHolder.instance.Select_Cannon_type.SetActive(false);
        HL_PrefabHolder.instance.Background_UI.SetActive(false);
    }
    public void NextRound()
    {
        HL_Level_Manager.instance.in_Next_Round_Target += 5;
        HL_Level_Manager.instance.bl_Round_Complete = false;
        HL_PrefabHolder.instance.Round_Complete.SetActive(false);
        HL_PrefabHolder.instance.Background_UI.SetActive(false);
        HL_PrefabHolder.instance.Upgrade_buttons.SetActive(false);
        HL_Level_Manager.instance.Ui_On_Off = false;
        HL_Upgrade_Asigment.instance.reset();
        HL_Level_Manager.instance.bl_Static = false;
    }
    public void OpenUpgrades()
    {
        HL_PrefabHolder.instance.Upgrade_buttons.SetActive(true);
        HL_PrefabHolder.instance.Round_Complete.SetActive(false);
    }
    public void CloseUpgrades()
    {
        HL_PrefabHolder.instance.Round_Complete.SetActive(true);
        HL_PrefabHolder.instance.Upgrade_buttons.SetActive(false);

    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(st_MainMenuName);
    }





}
