using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LoadLevelJson : MonoBehaviour
{
    public TextAsset dbAsset;
    public void LoadLvJson(string path)
    {
        TextAsset data = Resources.Load(path) as TextAsset;

        var jsonData = JSON.Parse(data.text);

        Debug.Log(jsonData.Count);
        Debug.Log(jsonData[0]["StageName"]);
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
