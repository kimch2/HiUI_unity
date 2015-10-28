﻿using UnityEngine;
using System.Collections;
using System;

namespace HiUI
{
    /// <summary>
    /// 游戏选项面板--------for example
    /// </summary>
    public class OpertionUIView : UIView
    {
        public override void RegisterMethod()
        {
            buttonEvenList.Add("Canvas/Button", OnButtonMusic);
        }
        /// <summary>
        /// 游戏背景音乐开关
        /// </summary>
        void OnButtonMusic()
        {
            Debug.Log("hello");
        }
        void OnButtonSound()
        {

        }
        /// <summary>
        /// 面板弹出动画
        /// </summary>
        public override void StartViewAnimation()
        {
            animator.Play("GameUIViewStartAnimation");
        }
        /// <summary>
        /// 面板关闭动画
        /// </summary>
        public override void ExistViewAnimation()
        {
            animator.Play("GameUIViewExistAnimation");
        }
    }
}

