using HiUI;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class UIButton : MonoBehaviour
{
    private string path;
    void Start()
    {
        Button _bt = GetComponent<Button>();
        if (_bt)
            _bt.onClick.AddListener(ButtonMessage);
    }

    void ButtonMessage()
    {
        UIView _uiView = GetComponentInParent<UIView>();
        if (_uiView)
            _uiView.OnButtonClick(GetPath(transform));
    }
    string GetPath(Transform _trans)
    {
        if (_trans.parent)
            GetParentPath(_trans.parent);

        path += _trans.name;
        return path;
    }
    void GetParentPath(Transform _trans)
    {
        path = _trans.name + "/" + path;
        if (_trans.parent)
            GetParentPath(_trans.parent);
    }
}



