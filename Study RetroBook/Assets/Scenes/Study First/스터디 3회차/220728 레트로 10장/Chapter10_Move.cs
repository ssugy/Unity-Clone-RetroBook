using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter10_Move : MonoBehaviour
{
    public Transform childTransForm;    // ������ �ڽ� ���� ������Ʈ�� Ʈ������

    private void Start()
    {
        // me�� ���� ��ġ�� 0 -1 0 ���� ����
        transform.position = new Vector3(0, -1, 0);
        // �ڽ��� ���� ��ġ�� 0 2 0���� ����
        childTransForm.localPosition = new Vector3(0, 2, 0);

        // me�� ���� ȸ���� 0 0 30���� ����
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        // �ڽ��� ���� ȸ���� 0 60 0���� ����
        childTransForm.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // ���� ����Ű�� ������ �ʴ� 0 1 0�� �ӵ��� �����̵�
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ������ ����Ű�� ������
            // me �ʴ� 0 0 -180�� ȸ��
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            childTransForm.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            childTransForm.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }
    }
}
