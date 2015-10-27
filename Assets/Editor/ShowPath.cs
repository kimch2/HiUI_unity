/// <summary>
/// for美工/策划编辑ui时使用
/// </summary>
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
            Debug.Log(GetPath(Selection.activeTransform));
        }
        static string GetPath(Transform _trans)
        {
            path = string.Empty;
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


