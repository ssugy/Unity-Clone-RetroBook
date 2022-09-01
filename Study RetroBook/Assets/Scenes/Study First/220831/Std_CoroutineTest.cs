using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 주혁님께서 작성해주신 코드입니다.
// 재귀함수의 방법으로 풀어주셨는데, 잘 풀어주셨습니다.
// 다만 하나 설명드릴 내용이 있어서 추가드릴께요.
// 재귀의 방법인 경우 문제가 되는 요소가 하나가 있습니다.
// 중간에 멈추는 stop코루틴에 관해서 정상적으로 작동하지 않을 수 있습니다.
//아래에 코드 예제를 들어놧습니다.
public class Std_CoroutineTest : MonoBehaviour
{
    //Coroutine co;
    //void Start()
    //{
    //     co = StartCoroutine(RT(5.0f));
    //}

    //IEnumerator RT(float rt)
    //{
    //    Debug.Log(rt);
    //    yield return new WaitForSeconds(rt);
    //    if ((rt / 2) >= 0.001f)
    //    {
    //        StartCoroutine(RT(rt / 2)); // 재귀함수의 코루틴 실행. 이 코루틴은 start단에서 실행한 코루틴과 다른 코루틴입니다.
    //    }
    //    else
    //    {
    //        yield return null;
    //    }

    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        print("1번 누름");
    //        //만약 내가 해당 코루틴을 멈추려고 한다면. 제대로 멈춰지지 않습니다.
    //        //그렇기에 코루틴으로 재귀함수는 되도록 사용하지 않으시면 좋습니다.
    //        StopCoroutine(co);  
    //    }
    //}


    // 제가 작성한 코드
    Vector3 startPos = new Vector3(1, 1, 1);
    Vector3 endPos = new Vector3(0, 1, 0);

    private void Start()
    {
        StartCoroutine(MoveVec(startPos, endPos));
    }

    float timeCnt;
    // 3동안, 1초에 60프레임으로 이동. (180)프레임이 요구됨
    //float moveTime = (1.0f / 60.0f) * Time.deltaTime;
    IEnumerator MoveVec(Vector3 start, Vector3 end)
    {
        timeCnt = Time.time;

        Vector3 dirVec = end - start;
        Vector3 currentPos = startPos;
        //while (currentPos != endPos)
        //while (Vector3.Distance(currentPos, end) > 0.001f)  //거리로 측정하는 방법
        while (currentPos.x > 0)  //거리로 측정하는 방법
        {
            Debug.Log(currentPos);
            //yield return new WaitForSeconds(moveTime);
            //yield return new WaitForSeconds(Time.deltaTime);
            yield return new WaitForEndOfFrame();
            //yield return new WaitForSeconds(1);
            currentPos += ((dirVec / 3) * Time.deltaTime);
        }

        Debug.Log(Time.time - timeCnt);
    }
    // 제가 원한 풀이는 사실 이런방식이였습니다.
}
