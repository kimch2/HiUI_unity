using UnityEngine;
using System.Collections;
using System;

namespace HiUI
{
    public class MainUIView : UIView
    {
        protected override void RegisterMethod()
        {
            buttonEvenList.Add("Canvas/Panel(main)/Button", OnButtonPlay);

            buttonEvenList.Add("Canvas/Panel(main)/Button 1", OnButtonOpertion);
        }

        void test()
        {
            UIViewManager.Instance.OpenUIView(UIViewManager.Instance.mainView);
        }


        void OnButtonPlay()
        {
            Debug.Log("play game");
        }
        void OnButtonOpertion()
        {
            CloseView();
            UIViewManager.Instance.OpenUIView(UIViewManager.Instance.opertionView);
        }
    }
}