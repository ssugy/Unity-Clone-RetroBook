using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class StudyScripts : MonoBehaviour
{

    enum State
    {
        idle = 0,
        Run = 1,
        AAA,
        AAB,
        ABB = 3,    // 이러면 중첩이 되는군
        BBB,
    }

    State state = State.idle;

    private void Start()
    {
        if (state == State.idle)
        {
            print($"idle 상태입니다.");
        }
    }

    private void Update()
    {
       
    }
}
