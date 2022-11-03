using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonUtilityExample : MonoBehaviour
{
    void Start()
    {
        JsonTestClass jTest1 = new JsonTestClass();
        string jsonData = JsonUtility.ToJson(jTest1);
        Debug.Log(jsonData);

        JsonTestClass jTest2 = JsonUtility.FromJson<JsonTestClass>(jsonData);
        jTest2.Print();
    }
}
