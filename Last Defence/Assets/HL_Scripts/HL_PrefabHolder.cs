using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_PrefabHolder : MonoBehaviour {
    public static HL_PrefabHolder instance;

    [Header("Canvas Holders")]
    public GameObject Background_UI;
    public GameObject Round_Complete;
    public GameObject Upgrade_buttons;
    public GameObject Select_Cannon_type;

    [Header("NPCs")]
    public GameObject Enemy_Targets;
    // Use this for initialization
    void Start ()
    {
        instance = this;
        Round_Complete = GameObject.Find("Round Compeet Screen");
        Select_Cannon_type = GameObject.Find("Cannon Type Selection");
        Upgrade_buttons = GameObject.Find("Upgrade Sceen");
        Background_UI = GameObject.Find("Sceen images");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
