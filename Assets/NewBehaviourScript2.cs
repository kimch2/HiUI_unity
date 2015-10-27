using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NewBehaviourScript2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Test);
    }
    void Test()
    {
        print("on click");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
