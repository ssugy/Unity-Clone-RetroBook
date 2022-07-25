using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

static class TestClass
{
    public struct Test
    {
        public int x;
    }
    public static int a = 0;
}

public class EventFunctions : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            

        }
    }

    #region 이벤트 함수

    private void OnEnable()
    {
        print("OnEnable : Enable될 때 실행, 스크립트건, 게임오브젝트건 실행됨. 그리고 플레이버튼 실행할 때 1회 실행됨");
    }


    private void Reset()
    {
        print("리셋 함수 실행 : 스크립트 붙일 때 한번 실행");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter : 트리거 엔터 실행");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("OnCollisionEnter : 콜리전 엔터 실행");
    }
    #endregion
}
