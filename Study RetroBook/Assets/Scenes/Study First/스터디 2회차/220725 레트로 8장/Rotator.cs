using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 바닥 회전 장치
 */
public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);    // Y축 회전
    }
}
