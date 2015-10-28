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

        protected override void StartViewAnimation()
        {
        }
        protected override void ExistViewAnimation()
        {
        }






        void test()
        {
            UIViewManager.Instance.OnUIView(UIViewManager.Instance.mainView);
        }
    }
}