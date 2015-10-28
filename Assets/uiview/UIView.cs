using UnityEngine;
using System.Collections.Generic;
using System;
namespace HiUI
{
    public class UIView : MonoBehaviour
    {
        protected Animator animator;
        protected Dictionary<string, Action> buttonEvenList = new Dictionary<string, Action>();
        /// <summary>
        /// 初始化面板
        /// </summary>
        void Start()
        {
            animator = GetComponent<Animator>();
            RegisterMethod();
            StartViewAnimation();
        }
        /// <summary>
        /// 子类注册方法
        /// </summary>
        public virtual void RegisterMethod()
        {

        }
        /// <summary>
        /// 面板弹出动画
        /// </summary>
        public virtual void StartViewAnimation()
        {

        }
        /// <summary>
        /// 面板关闭动画
        /// </summary>
        public virtual void ExistViewAnimation()
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
