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
        OpenUIView(uiViewList[_path]);
    }
    void OpenUIView(UIView _uiView)
    {
        _uiView.gameObject.SetActive(true);
        _uiView.StartViewAnimation();
        foreach (KeyValuePair<UIViewPath, UIView> uiView in uiViewList)
        {
            if ((uiView.Value != _uiView) && (uiView.Value.gameObject.activeSelf))
            {
                uiView.Value.ExistViewAnimation();
            }
        }
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