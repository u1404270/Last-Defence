using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class HL_Save_Load_Manager : MonoBehaviour {
    public static HL_Save_Load_Manager instance;
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
    public void Save()
    {
        BinaryFormatter BF = new BinaryFormatter();
        // the location of where it will  be saved
        FileStream SaveFile = File.Create(Application.persistentDataPath + "/LDSave.dat");
        //--
        SaveData data = new SaveData();
        // here add the variables that are ment to be saved
        data.CurrentWave = HL_Level_Manager.instance.in_Current_Round;


        //--
        //--
        BF.Serialize(SaveFile, data);
        SaveFile.Close();
    }
    public void LoadLastGame()
    { 
        if(File.Exists(Application.persistentDataPath + "/LDSave.dat"))
        {
            BinaryFormatter Bf = new BinaryFormatter();
            FileStream SaveFile = File.Open(Application.persistentDataPath + "/LDSave.dat", FileMode.Open);
            SaveData data = (SaveData) Bf.Deserialize(SaveFile);
            SaveFile.Close();

            // variables that have to be loaded and asigned
            HL_Level_Manager.instance.in_Current_Round = data.CurrentWave;
            //--

        }

	}
}


[Serializable]
class SaveData
{
    public int CurrentWave;
}
