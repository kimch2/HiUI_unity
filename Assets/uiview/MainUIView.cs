using UnityEngine;
using System.Collections;
using System;

namespace HiUI
{
    public class MainUIView : UIView
    {
        protected override void RegisterMethod()
        {
        }

        void test()
        {
            UIViewManager.Instance.OnUIView(UIViewManager.Instance.mainView);
        }
    }
}