using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveSave (string KeyName, string Value) {
        PlayerPrefs.SetString(KeyName, Value);
    }

    public void loadSave (string KeyName, string Value) {
        PlayerPrefs.GetString(KeyName, Value);
    }

    public void saveSave1 () {
        saveSave("saveSaveSave", "save1");
    }

    public void saveSave2 () {
        saveSave("saveSaveSave", "save2");
    }
    
    public void saveSave3 () {
        saveSave("saveSaveSave", "save3");
    }
}
