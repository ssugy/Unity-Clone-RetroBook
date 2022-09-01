using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

/**
 * Async, await, Task (3���� �׻� ���� �ٴѴ�.)
 * ����Ϸ��� : ĵ����ū�ҽ����ִ� ��ū�� �־�����Ѵ�.
 */
public class Std_AsyncAwait : MonoBehaviour
{
    CancellationTokenSource cts;

    private void Start()
    {
        // �ָ� ���߷��� ��ū�� �ʿ��ϴ�. => ������ �±�
        //�׷��� Ư�� �±׸� �Ѳ����� ���� �� �ִ�.
        //stop�̶�� ǥ���� �Ⱦ��� cancel�̷� ǥ���� ����.
        cts = new CancellationTokenSource();
        EatPotion();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1�� ��ư ����");
            cts.Cancel();
        }
    }

    int health = 0;
    async void EatPotion()
    {
        while (true)
        {
            health += 10;
            Debug.Log($"����� ü���� {health}�Դϴ�.");

            if (health > 100)
                break;
            await MysecondFunc();
        }
    }

    async Task MysecondFunc()
    {
        Debug.Log("�ι�° �Լ� ����");
        await Task.Delay(1000, cts.Token);
        Debug.Log("�ι�° �Լ� ����");
        await MyThirdFunc();
    }

    async Task MyThirdFunc()
    {
        Debug.Log("����° �Լ� ����");
        await Task.Delay(2000, cts.Token);
        Debug.Log("����° �Լ� ����");
    }
}
