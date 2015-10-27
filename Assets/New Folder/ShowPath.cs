using UnityEditor;
using UnityEngine;

namespace HiUI
{
    public class ShowPath
    {
        static string path;
        [MenuItem("UI/显示路径")]
        static void ShowTransformPath()
        {
            path = string.Empty;
            Debug.Log(GetPath(Selection.activeTransform));
        }
        static string GetPath(Transform _trans)
        {
            if (_trans.parent)
                GetParentPath(_trans.parent);

            path += _trans.name;
            return path;
        }
        static void GetParentPath(Transform _trans)
        {
            path = _trans.name + "/" + path;
            if (_trans.parent)
                GetParentPath(_trans.parent);
        }
    }
}


