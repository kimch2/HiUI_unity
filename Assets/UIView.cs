using UnityEngine;
using System.Collections.Generic;
namespace HiUI
{
    public class UIView : MonoBehaviour
    {
        private delegate void ButtonDelegate();
        private Dictionary<string, ButtonDelegate> buttonDelegateList = new Dictionary<string, ButtonDelegate>();
        void Start()
        {
            buttonDelegateList.Add("button", OnTest);





        }
        void RegisterMethod()
        {




        }
        public void OnButtonClick(string _key)
        {
            if (buttonDelegateList.ContainsKey(_key))
                buttonDelegateList[_key]();
            else
                Debug.LogWarning("please register method");
        }
        private void OnTest()
        {
            Debug.Log("excute");
        }
    }
}
