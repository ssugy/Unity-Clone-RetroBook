using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake03 : MonoBehaviour
{
    //1번 Awake와 start의 순서
    //private void Awake()
    //{
    //    print(name + " Awake 실행");
    //}

    //void Start()
    //{
    //    print($"{name} Start 실행");
    //}

    private void Start()
    {
        GameObject.Find("Awake 2번").GetComponent<Awake02>();
    }
}
