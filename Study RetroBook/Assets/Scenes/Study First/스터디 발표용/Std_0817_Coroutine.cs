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
        Debug.Log("num2 실행");
    }

    // Start is called before the first frame update
    void Start()
    {
        // 코루틴 실행하는 방법 1번
        StartCoroutine("ChangeNum");

        // 코루틴과 유사하게 실행하는 방법 
        Invoke("ChangeNum2", 1);    // 1초뒤에 실행
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 코루틴 실행하는 방법 2번
            StartCoroutine(ChangeNum());
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 코루틴 멈추는 법
            StopAllCoroutines();
        }
    }
}
