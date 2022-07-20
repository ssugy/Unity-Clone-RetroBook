using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyClass
{
    public int a = 1;
    public int b = 2;
}


public class Awake02 : MonoBehaviour
{
    public MyClass myClass = new MyClass();

    private int num = 1;

    private void Start()
    {
        
    }
}
