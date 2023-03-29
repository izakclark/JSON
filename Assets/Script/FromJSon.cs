using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using SimpleJSON;

public class FromJSon : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        string fromJsonData = PlayerPrefs.GetString("PlayerData");

        Debug.Log(fromJsonData);

        Player player = JsonUtility.FromJson<Player>(fromJsonData);

        Debug.Log($"�÷��̾� �̸� : {player.pName}");

        var jsonData = JSON.Parse(fromJsonData);

        Debug.Log($"a�÷��̾� �̸� : {jsonData["pName"]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
