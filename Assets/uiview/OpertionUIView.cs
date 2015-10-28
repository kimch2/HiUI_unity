using UnityEngine;
using System.Collections;
using System;

namespace HiUI
{
    /// <summary>
    /// 游戏选项面板
    /// </summary>
    public class OpertionUIView : UIView
    {
        protected override void RegisterMethod()
        {
            buttonEvenList.Add("Canvas/Panel(opertion)/Button", OnButtonMusic);
            buttonEvenList.Add("Canvas/Panel(opertion) / Button 1", OnButtonSound);
            buttonEvenList.Add("Canvas/Panel(opertion)/Button 2", OnClose);
        }
        /// <summary>
        /// 游戏背景音乐开关
        /// </summary>
        void OnButtonMusic()
        {
            Debug.Log("music on/off");
        }
        void OnButtonSound()
        {
            Debug.Log("sound on/off");
        }
        void OnClose()
        {
            CloseView();
        }
    }
}

