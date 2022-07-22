using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctions : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print(gameObject.activeSelf);
            gameObject.SetActive(!gameObject.activeSelf);   // �̰� �ȵǴ°�, setactive(false)�ϸ� update��ü�� �ȵ��ư�.
        }
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
