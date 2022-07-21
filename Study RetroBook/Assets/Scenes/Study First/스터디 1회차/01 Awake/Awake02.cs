using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MyClass
{
    public int a = 1;
    public int b = 2;
}


public class Awake02 : MonoBehaviour
{
    public MyClass myClass = new MyClass();

    [SerializeField] private int num = 0;

    private void Start()
    {
        
    }
}
