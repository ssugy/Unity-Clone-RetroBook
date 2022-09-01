using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * �ڷ�ƾ
 * 1. ������ ���ø� -> 1�ʿ� ü���� 10�� ����. 10�ʵ��� => ����?
 *  1) timeCnt; Time.time
 * 1. time.deltatime�� ���ؼ� �Ѵ�.
 *  - �����ϳ� ���� ������Ʈ�� �������� �ϰ� �װ� 1�� �Ǹ� �Լ� ���� 0���� �ʱ�ȭ
 * 2. Coroutine ����ؼ� 1�ʵ����� 
 * 3. async-await
 * 4. invokerepeat
 */
public class Std_0817_Coroutine : MonoBehaviour
{
    Coroutine co;

    private void Start()
    {
        //StartCoroutine("EatPotion"); // ��� 1 -> �̰ſ־���?
        //co = StartCoroutine(EatPotion()); // ��� 2 -> �����߳�?? �����̰�.
    }
    private void Update()
    {
        StartCoroutine(EatPotion());

        // �������ϴ°��� ��ư 1���� ������, �������� �ǰ� ���� ���߿� ���ߴ� ��.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1�� ��ư ����");
            //�ڷ�ƾ�� ����� �ȴ�.
            //StopCoroutine("EatPotion");
            StopCoroutine(co);
        }
    }

    //�Ű����� = ����δ� �Ķ���� = ���������ϴ°�? => �Լ������� �Ķ����
    int health = 0;
    IEnumerator EatPotion()
    {
        Debug.Log("������ �Ծ����ϴ�.");
        while (true)
        {
            health += 10;
            Debug.Log($"����� ü���� {health}�Դϴ�.");

            if (health > 100)
                break;

            yield return new WaitForSeconds(1);
        }
    }
}
