using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Std_0817_Coroutine : MonoBehaviour
{
    int cnt = 0;
    IEnumerator ChangeNum()
    {
        cnt = 0;
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(cnt++);
            yield return new WaitForSeconds(1f);
        }
    }

    public void ChangeNum2()
    {
        Debug.Log("num2 ����");
    }

    // Start is called before the first frame update
    void Start()
    {
        // �ڷ�ƾ �����ϴ� ��� 1��
        StartCoroutine("ChangeNum");

        // �ڷ�ƾ�� �����ϰ� �����ϴ� ��� 
        Invoke("ChangeNum2", 1);    // 1�ʵڿ� ����
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // �ڷ�ƾ �����ϴ� ��� 2��
            StartCoroutine(ChangeNum());
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // �ڷ�ƾ ���ߴ� ��
            StopAllCoroutines();
        }
    }
}
