using UnityEngine;
using System.Collections;

public class Test1 : MonoBehaviour
{

    void Start()
    {
        Test(1);
        Test(1, 2, 3);
    }
    void Test(params int[] x)//参数数量可变
    {

    }
}
