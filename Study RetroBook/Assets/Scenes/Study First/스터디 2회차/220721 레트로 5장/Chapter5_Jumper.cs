using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;

    void Start()
    {
        // y��(��) �������� 500��ŭ�� ��.
        myRigidbody.AddForce(0, 500, 0);
    }
}
