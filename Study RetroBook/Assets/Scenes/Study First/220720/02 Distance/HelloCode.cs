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
        
        //������ǥ = ��(�ֻ���)�� �߾ӿ��� �󸶳� �����ִ���?
        print("���� ������ " + go1.transform.position.ToString());

        //������ǥ = �θ�κ��� �󸶳� �������ִ���??
        print("���� ������ " + go1.transform.localPosition.ToString());
    }
}
