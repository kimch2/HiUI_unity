using UnityEngine;
using System.Collections.Generic;
using System;
namespace HiUI
{
    public class UIView : MonoBehaviour
    {
        protected Dictionary<string, Action> buttonEvenList = new Dictionary<string, Action>();
        void Start()
        {
            RegisterMethod();
        }
        public virtual void RegisterMethod()
        {

        }
        public void OnButtonClick(string _key)
        {
            if (buttonEvenList.ContainsKey(_key))
                buttonEvenList[_key]();
            else
                Debug.LogWarning("Cann't find the method, please check and register method");
        }
    }
}
