using UnityEngine;
using System.Collections.Generic;
using System;
namespace HiUI
{
    public abstract class UIView : MonoBehaviour
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
            StartView();
        }
        /// <summary>
        /// 子类注册方法
        /// </summary>
        protected abstract void RegisterMethod();
        /// <summary>
        /// 面板弹出动画
        /// </summary>
        public void StartView()
        {
            if (animator)
                animator.Play("Start");
        }
        /// <summary>
        /// 面板关闭动画
        /// </summary>
        public void CloseView()
        {
            if (animator)
                animator.Play("Exist");
            else
                gameObject.SetActive(false);
        }
        /// <summary>
        /// 面板动画播放完毕后隐藏面板
        /// </summary>
        protected void CloseViewCallBack()
        {
            gameObject.SetActive(false);
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
