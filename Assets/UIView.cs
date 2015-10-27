using UnityEngine;
using System.Collections.Generic;
namespace HiUI
{
    public class UIView : MonoBehaviour
    {
        private delegate void ButtonDelegate();
        private Dictionary<string, ButtonDelegate> _buttonDelegateList = new Dictionary<string, ButtonDelegate>();
        void Start()
        {
            _buttonDelegateList.Add("button", OnLog);
        }
        public void OnButtonClick(string _key)
        {
            if (_buttonDelegateList.ContainsKey(_key))
                _buttonDelegateList[_key]();
        }
        private void OnLog()
        {
            Debug.Log("do");
        }
    }


}
