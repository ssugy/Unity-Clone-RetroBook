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
        ABB = 3,    // �̷��� ��ø�� �Ǵ±�
        BBB,
    }

    State state = State.idle;

    private void Start()
    {
        if (state == State.idle)
        {
            print($"idle �����Դϴ�.");
        }
    }

    private void Update()
    {
       
    }
}
