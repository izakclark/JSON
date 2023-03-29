using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
using Unity.VisualScripting;

public class LoadDataJson : MonoBehaviour
{
    public GameObject characterPrefab;


    public void LoaddataJson(string json)
    {
        TextAsset data = Resources.Load(json) as TextAsset;

        var jsonData = JSON.Parse(data.text);

        int rnd = Random.Range(0, jsonData.Count);
        GameObject character=Instantiate(characterPrefab);

        string nameInJSON = jsonData[rnd]["Name"].ToString();
        character.name = nameInJSON.Replace("\"", "");

        character.GetComponent<Status>().hp = float.Parse(jsonData[rnd]["HP"].ToString());
        character.GetComponent<Status>().mp = float.Parse(jsonData[rnd]["MP"].ToString());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
