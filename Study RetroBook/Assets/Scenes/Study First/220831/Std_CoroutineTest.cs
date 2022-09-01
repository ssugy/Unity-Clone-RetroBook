using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����Բ��� �ۼ����ֽ� �ڵ��Դϴ�.
// ����Լ��� ������� Ǯ���̴ּµ�, �� Ǯ���ּ̽��ϴ�.
// �ٸ� �ϳ� ����帱 ������ �־ �߰��帱����.
// ����� ����� ��� ������ �Ǵ� ��Ұ� �ϳ��� �ֽ��ϴ�.
// �߰��� ���ߴ� stop�ڷ�ƾ�� ���ؼ� ���������� �۵����� ���� �� �ֽ��ϴ�.
//�Ʒ��� �ڵ� ������ ���J���ϴ�.
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
    //        StartCoroutine(RT(rt / 2)); // ����Լ��� �ڷ�ƾ ����. �� �ڷ�ƾ�� start�ܿ��� ������ �ڷ�ƾ�� �ٸ� �ڷ�ƾ�Դϴ�.
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
    //        print("1�� ����");
    //        //���� ���� �ش� �ڷ�ƾ�� ���߷��� �Ѵٸ�. ����� �������� �ʽ��ϴ�.
    //        //�׷��⿡ �ڷ�ƾ���� ����Լ��� �ǵ��� ������� �����ø� �����ϴ�.
    //        StopCoroutine(co);  
    //    }
    //}


    // ���� �ۼ��� �ڵ�
    Vector3 startPos = new Vector3(1, 1, 1);
    Vector3 endPos = new Vector3(0, 1, 0);

    private void Start()
    {
        StartCoroutine(MoveVec(startPos, endPos));
    }

    float timeCnt;
    // 3����, 1�ʿ� 60���������� �̵�. (180)�������� �䱸��
    //float moveTime = (1.0f / 60.0f) * Time.deltaTime;
    IEnumerator MoveVec(Vector3 start, Vector3 end)
    {
        timeCnt = Time.time;

        Vector3 dirVec = end - start;
        Vector3 currentPos = startPos;
        //while (currentPos != endPos)
        //while (Vector3.Distance(currentPos, end) > 0.001f)  //�Ÿ��� �����ϴ� ���
        while (currentPos.x > 0)  //�Ÿ��� �����ϴ� ���
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
    // ���� ���� Ǯ�̴� ��� �̷�����̿����ϴ�.
}
