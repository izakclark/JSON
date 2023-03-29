using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLevelCsv : MonoBehaviour
{
    public List<Dictionary<string, object>> data;
    public Text dataTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void LoadLevel(string path)
    {
        data = CSVReader.Read(path);
        dataTxt.text = "";
        for(int i = 0; i<data.Count; ++i)
        {
            dataTxt.text+=data[i]["StageName"] + "\n";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
