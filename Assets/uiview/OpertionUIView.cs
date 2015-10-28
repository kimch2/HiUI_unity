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
            buttonEvenList.Add("Canvas/Button", OnButtonMusic);
            buttonEvenList.Add("Canvas/Button", OnButtonSound);
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
    }
}

