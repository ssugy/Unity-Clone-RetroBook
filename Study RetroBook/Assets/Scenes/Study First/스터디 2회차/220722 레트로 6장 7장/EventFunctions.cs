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
    private void FixedUpdate()
    {
        //print("Fixed Update");
    }

    private void Update()
    {
        //print("Update");
    }

    private void LateUpdate()
    {
        //print("����Ʈ Update");
    }

    #region �̺�Ʈ �Լ�

    private void OnEnable()
    {
        print("OnEnable : Enable�� �� ����, ��ũ��Ʈ��, ���ӿ�����Ʈ�� �����. �׸��� �÷��̹�ư ������ �� 1ȸ �����");
    }


    private void Reset()
    {
        print("���� �Լ� ���� : ��ũ��Ʈ ���� �� �ѹ� ����");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter : Ʈ���� ���� ����");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("OnCollisionEnter : �ݸ��� ���� ����");
    }
    #endregion
}
