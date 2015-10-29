using UnityEngine;
using System.Collections;

public class UIViewRoot : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        UIViewManager.Instance.OpenUIView(UIViewManager.Instance.mainView);
    }

}
