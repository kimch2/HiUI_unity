using UnityEngine;
using System.Collections;
using System;

namespace HiUI
{
    public class GameUIView : UIView
    {
        public override void RegisterMethod()
        {
            Debug.Log("subclass start register method");
            buttonEvenList.Add("Canvas/Button", OnButton_1);
            buttonEvenList.Add("", OnButton_2);
            // buttonEvenList.Add("", OnButton_3);
        }

        void OnButton_1()
        {
            Debug.Log("hello");
        }
        void OnButton_2()
        {

        }
        void OnButton_3()
        {

        }
    }
}

