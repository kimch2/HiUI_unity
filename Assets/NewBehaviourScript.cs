using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class NewBehaviourScript : MonoBehaviour
{
    public delegate void TestDelegate();

    Dictionary<string, TestDelegate> td = new Dictionary<string, TestDelegate>();

    // Use this for initialization
    void Start()
    {
        string button = "t/sub";
        TestDelegate t = Log;

        td.Add(button, Log);

        Debug.Log(string.Format(td.Count.ToString()));


        if (td.ContainsKey(button))
            td[button]();


        Debug.Log(GetHashCode());



    }

    // Update is called once per frame
    void Update()
    {

    }

    void Log()
    {
        Debug.Log("do");
    }
}


