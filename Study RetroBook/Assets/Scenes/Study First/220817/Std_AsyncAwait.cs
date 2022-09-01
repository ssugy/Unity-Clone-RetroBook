using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

/**
 * Async, await, Task (3개가 항상 같이 다닌다.)
 * 취소하려면 : 캔슬토큰소스에있는 토큰을 넣어줘야한다.
 */
public class Std_AsyncAwait : MonoBehaviour
{
    CancellationTokenSource cts;

    private void Start()
    {
        // 애를 멈추려면 토큰이 필요하다. => 일종의 태그
        //그래서 특정 태그만 한꺼번에 멈출 수 있다.
        //stop이라는 표현을 안쓰고 cancel이런 표현을 쓴다.
        cts = new CancellationTokenSource();
        EatPotion();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1번 버튼 누름");
            cts.Cancel();
        }
    }

    int health = 0;
    async void EatPotion()
    {
        while (true)
        {
            health += 10;
            Debug.Log($"용사의 체력은 {health}입니다.");

            if (health > 100)
                break;
            await MysecondFunc();
        }
    }

    async Task MysecondFunc()
    {
        Debug.Log("두번째 함수 실행");
        await Task.Delay(1000, cts.Token);
        Debug.Log("두번째 함수 종료");
        await MyThirdFunc();
    }

    async Task MyThirdFunc()
    {
        Debug.Log("세번째 함수 실행");
        await Task.Delay(2000, cts.Token);
        Debug.Log("세번째 함수 종료");
    }
}
