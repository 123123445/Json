using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using Newtonsoft.Json;

public class JsonSaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //FileStream stream = new FileStream(Application.dataPath + "/test.json", FileMode.OpenOrCreate);
        //JsonTestClass jTest1 = new JsonTestClass();
        //string jsonData = JsonConvert.SerializeObject(jTest1);
        //byte[] data = Encoding.UTF8.GetBytes(jsonData);
        //stream.Write(data, 0, data.Length);
        //stream.Close();

        FileStream stream = new FileStream(Application.dataPath + "/test.json", FileMode.Open);
        byte[] data = new byte[stream.Length];
        stream.Read(data, 0, data.Length);
        stream.Close();
        string jsondata = Encoding.UTF8.GetString(data);
        JsonTestClass jTest2 = JsonConvert.DeserializeObject<JsonTestClass>(jsondata);
        jTest2.Print();
    }
}
