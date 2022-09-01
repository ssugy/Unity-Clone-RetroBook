using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 코루틴
 * 1. 물약을 마시면 -> 1초에 체력이 10씩 찬다. 10초동안 => 구현?
 *  1) timeCnt; Time.time
 * 1. time.deltatime을 더해서 한다.
 *  - 변수하나 만들어서 업데이트때 더해지게 하고 그게 1이 되면 함수 실행 0으로 초기화
 * 2. Coroutine 사용해서 1초딜레이 
 * 3. async-await
 * 4. invokerepeat
 */
public class Std_0817_Coroutine : MonoBehaviour
{
    Coroutine co;

    private void Start()
    {
        //StartCoroutine("EatPotion"); // 방법 1 -> 이거왜쓰죠?
        //co = StartCoroutine(EatPotion()); // 방법 2 -> 못멈추네?? 뭐야이게.
    }
    private void Update()
    {
        StartCoroutine(EatPotion());

        // 내가원하는것은 버튼 1번을 누르면, 물약으로 피가 차던 도중에 멈추는 것.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1번 버튼 누름");
            //코루틴을 멈춰야 된다.
            //StopCoroutine("EatPotion");
            StopCoroutine(co);
        }
    }

    //매개변수 = 영어로는 파라미터 = 값을전달하는것? => 함수에서의 파라미터
    int health = 0;
    IEnumerator EatPotion()
    {
        Debug.Log("물약을 먹었습니다.");
        while (true)
        {
            health += 10;
            Debug.Log($"용사의 체력은 {health}입니다.");

            if (health > 100)
                break;

            yield return new WaitForSeconds(1);
        }
    }
}
