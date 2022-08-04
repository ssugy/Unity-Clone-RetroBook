using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Example1.Awake() was called");
    }

    void Start()
    {
        Debug.Log("Example1.Start() was called");
    }

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            print("b key was pressed");
        }
    }
}
