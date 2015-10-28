using HiUI;
using System.Collections.Generic;

public enum UIViewType
{
    Main,//主面板
    Opertion,//选项面板
    Pause,//暂停游戏面板
}
public class UIViewManager
{
    Dictionary<UIViewType, UIView> uiViewList = new Dictionary<UIViewType, UIView>();


    public UIView GetUIView(UIViewType _type)
    {
        if (!(uiViewList.ContainsKey(_type)) && (!uiViewList[_type]))
        {

        }

        return null;
    }

}
