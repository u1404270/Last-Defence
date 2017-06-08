using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_TEmp_Enemy_Health : MonoBehaviour {


    public float health = 200;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ReviceDamage(int damageRecived)
    {
        health -= damageRecived;
        if ( health <= 0)
        {
            HL_Level_Manager.instance.TotalTargets.Remove(gameObject);
            Destroy(gameObject);
            
        }
    }
}
