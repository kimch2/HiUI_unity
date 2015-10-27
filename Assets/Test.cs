using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class Test : MonoBehaviour
{
    public GameObject button;
    // Use this for initialization
    void Start()
    {
        var trigger = button.GetComponent<EventTrigger>();
        trigger.delegates = new List<EventTrigger.Entry>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback = new EventTrigger.TriggerEvent();





        UnityAction<BaseEventData> callback = new UnityAction<BaseEventData>(Log);
        entry.callback.AddListener(callback);
        // 添加事件触发记录到GameObject的事件触发组件
        trigger.delegates.Add(entry);

    }

    void Log(BaseEventData data)
    {
        Debug.Log(data.selectedObject.name);
    }

    public void tet(int x)
    { }
    public void D()
    { }
}
