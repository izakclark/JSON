using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public string pName;
    public int pLv;
}
public class ToJSON : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player();

        player.pName = "Player1";
        player.pLv = 1;

       // Debug.Log(player.pName);
       // Debug.Log(player.pLv);

        string jsonData = JsonUtility.ToJson(player);

        Debug.Log(jsonData);

        PlayerPrefs.SetString("PlayerData", jsonData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
