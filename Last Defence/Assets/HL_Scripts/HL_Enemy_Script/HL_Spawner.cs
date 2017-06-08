using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_Spawner : MonoBehaviour {

    GameObject mySpawned;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (HL_Level_Manager.instance.bl_Wave_Start == true && mySpawned == null && HL_Level_Manager.instance.Max_Pawn >0)
        {
            mySpawned = Instantiate(HL_PrefabHolder.instance.Enemy_Targets, gameObject.transform.position, gameObject.transform.rotation);
            HL_Level_Manager.instance.TotalTargets.Add(mySpawned);
            HL_Level_Manager.instance.Max_Pawn--;
        }
	}
}
