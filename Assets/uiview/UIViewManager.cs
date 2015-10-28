using HiUI;
using System.Collections.Generic;
using UnityEngine;
public class UIViewManager : Singleton<UIViewManager>
{
    public UIViewPath mainView = new UIViewPath("Resources/ui/main");
    public UIViewPath opertionView = new UIViewPath("Resources/ui/opertion");


    Dictionary<UIViewPath, UIView> uiViewList = new Dictionary<UIViewPath, UIView>();

    public void OnUIView(UIViewPath _path)
    {
        if (!(uiViewList.ContainsKey(_path)) || (!uiViewList[_path]))
        {
            GameObject go = (GameObject)Resources.Load(_path.path);
            UIView uiView = go.GetComponent<UIView>();
            uiViewList.Add(_path, uiView);
        }
        Open(uiViewList[_path]);
    }



    void Open(UIView _uiView)
    {

    }










    public class UIViewPath
    {
        public string path;
        public UIViewPath(string _path)
        {
            path = _path;
        }
    }
}