using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HL_Stats_Display : MonoBehaviour {
    public GameObject holder;
    Text PowerCore;
    Text MoveSpeed;
    Text ReloadSpeed;
    Text FireRate;
    Text Magazine;
    Text AmmoDump ;
    Text AmunitionUpgrade ;
    Text InpactDamage;
    Text AoeDAmage;
    Text CurentWave;


    public HL_Upgrade_Manager manager;
	// Use this for initialization
	void Start () {
        manager = holder.GetComponent<HL_Upgrade_Manager>();

        PowerCore = gameObject.transform.GetChild(0).GetComponent<Text>();
        MoveSpeed = gameObject.transform.GetChild(1).GetComponent<Text>();
        ReloadSpeed = gameObject.transform.GetChild(2).GetComponent<Text>();
        FireRate = gameObject.transform.GetChild(3).GetComponent<Text>();
        Magazine = gameObject.transform.GetChild(4).GetComponent<Text>();
        AmmoDump = gameObject.transform.GetChild(5).GetComponent<Text>();
       // AmunitionUpgrade = gameObject.transform.GetChild(0).GetComponent<Text>();
        InpactDamage = gameObject.transform.GetChild(6).GetComponent<Text>();
        AoeDAmage = gameObject.transform.GetChild(7).GetComponent<Text>();
        CurentWave = gameObject.transform.GetChild(9).GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        TempStatsDisplay();

    }
    void TempStatsDisplay()
    {
        PowerCore.text = "PowerCore:" + "" + manager.in_CorePoint.ToString();
        MoveSpeed.text = "MoveSpeed:" + "" + manager.in_Speed_Modifier.ToString();
        ReloadSpeed.text = "ReloadSpeed:" + "" + manager.fl_Relod_Modifier.ToString();
        FireRate.text = "FireRate:" + "" + manager.fl_FireRate_Modifier.ToString();
        Magazine.text = "Magazine:" + "" + manager.in_Magazine_Modifier.ToString();
        AmmoDump.text = "AmmoDump:" + "" + manager.in_AmmoDump_Modifier.ToString();
        InpactDamage.text = "InpactDamage:" + "" + manager.in_InpactAmmo_Modifier.ToString();
        AoeDAmage.text = "AoeDAmage:" + "" + manager.in_AOE_Ammo_Modifier.ToString();
        //PowerCore.text = "PowerCore:" + "" + manager.in_CorePoint.ToString();
        CurentWave.text = "Wave" + "" + HL_Level_Manager.instance.in_Current_Round.ToString();
    }
}
