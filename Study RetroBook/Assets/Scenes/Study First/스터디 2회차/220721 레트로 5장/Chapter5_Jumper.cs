using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;

    void Start()
    {
        // y축(위) 방향으로 500만큼의 힘.
        myRigidbody.AddForce(0, 500, 0);
    }
}
