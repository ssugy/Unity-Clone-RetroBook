using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Std_ActionEvent : MonoBehaviour
{
    Action playerSchedule;
    private int num = 0;

    private void Start()
    {
        playerSchedule += WakeUp;
        playerSchedule += WakeUp;

        playerSchedule();
    }

    private void WakeUp()
    {
        Debug.Log($"�ῡ�� �Ͼ {num++}");
    }

    private void EatMorning()
    {
        Debug.Log("��Ծ����ϴ�.");
    }
}
