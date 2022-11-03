using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class NewtonsoftJsonExample : MonoBehaviour
{
    private void Start()
    {
        JsonTestClass jTest1 = new JsonTestClass();
        string JsonData = JsonConvert.SerializeObject(jTest1);
        Debug.Log(JsonData);
        JsonTestClass jTest2 = JsonConvert.DeserializeObject<JsonTestClass>(JsonData);
        jTest2.Print();
    }
}

public class JsonTestClass
{
    public int i;
    public float f;
    public bool b;
    public string str;
    public int[] iArray;
    public List<int> iList = new List<int>();
    public Dictionary<string, float> fDictionary = new Dictionary<string, float>();
    public IntVector2 iVector;

    public JsonTestClass()
    {
        i = 10;
        f = 11.1f;
        b = true;
        str = "JSON Test";
        iArray = new int[] { 1, 2, 3, 4, 5, 6 };

        for (int i = 0; i < 5; i++)
        {
            iList.Add(i);
        }
        fDictionary.Add("1", 4);
        fDictionary.Add("2", 5);
        fDictionary.Add("3", 6);

        iVector = new IntVector2(2, 3);
    }

    public void Print()
    {
        Debug.Log(i);
        Debug.Log(f);
        Debug.Log(b);
        Debug.Log(str);

        for (int i = 0; i < iArray.Length; i++)
        {
            Debug.Log(string.Format("iArray[{0}] = {1}", i, iArray[i]));
        }

        for (int i = 0; i < iList.Count; i++)
        {
            Debug.Log(string.Format("iList[{0}] = {1}", i, iList[i]));
        }

        foreach (var data in fDictionary)
        {
            Debug.Log(string.Format("iDictionary[{0}] = {1}", data.Key, data.Value));
        }

        Debug.Log("iVector = " + iVector.x + "," + iVector.y);
    }

    public class IntVector2
    {
        public int x;
        public int y;

        public IntVector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}