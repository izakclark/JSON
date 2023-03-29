using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadDataCSV : MonoBehaviour
{
    public List<Dictionary<string, object>> data;
    public GameObject character;
    
    public void LoadDate(string path)
    {
        data = CSVReader.Read(path);

        int Rnd = Random.Range(0, data.Count);

        
        Instantiate(character);

        character.name = data[Rnd]["Name"].ToString();
        
        character.GetComponent<Status>().hp = float.Parse(data[Rnd]["HP"].ToString());
        character.GetComponent<Status>().mp = float.Parse(data[Rnd]["MP"].ToString());
        
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
