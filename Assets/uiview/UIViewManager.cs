using HiUI;
using System.Collections.Generic;
using UnityEngine;
public class UIViewManager : Singleton_Mono<UIViewManager>
{
    public Transform uiRoot;
    public UIViewInfo mainView = new UIViewInfo(" ui/main");
    public UIViewInfo opertionView = new UIViewInfo("Panel(opertion)");


    private Dictionary<UIViewInfo, UIView> uiViewList = new Dictionary<UIViewInfo, UIView>();
    public void OpenUIView(UIViewInfo _path)
    {
        if (!(uiViewList.ContainsKey(_path)) || (!uiViewList[_path]))
        {
            GameObject go = (GameObject)Instantiate(Resources.Load(_path.path));
            go.transform.SetParent(uiRoot);
            go.GetComponent<RectTransform>().localPosition = Vector3.zero;
            go.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
            UIView uiView = go.GetComponent<UIView>();
            uiViewList.Add(_path, uiView);
        }
        uiViewList[_path].gameObject.SetActive(true);
        uiViewList[_path].StartView();
        foreach (KeyValuePair<UIViewInfo, UIView> uiView in uiViewList)
            if ((uiView.Value != uiViewList[_path]) && (uiView.Value.gameObject.activeSelf))
                uiView.Value.CloseView();
    }
    public class UIViewInfo
    {
        public string path;
        public UIViewInfo(string _path)
        {
            path = _path;
        }
    }
}