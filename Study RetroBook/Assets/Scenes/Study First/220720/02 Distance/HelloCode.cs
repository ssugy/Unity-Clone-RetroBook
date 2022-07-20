using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloCode : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public TextMeshProUGUI textMesh1;

    float dist;

    void Update()
    {
        //dist = Vector3.Distance(go1.transform.position, go2.transform.position);
        
        //월드좌표 = 씬(최상위)의 중앙에서 얼마나 떨어있느냐?
        print("월드 포지션 " + go1.transform.position.ToString());

        //로컬좌표 = 부모로부터 얼마나 떨어져있느냐??
        print("로컬 포지션 " + go1.transform.localPosition.ToString());
    }
}
