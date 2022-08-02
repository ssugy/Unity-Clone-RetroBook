﻿using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour {
    public float speed = 10f; // 이동 속도

    private void Update() {
        // 초당 speed의 속도로 왼쪽으로 평행이동
        transform.Translate(Vector3.left * Time.deltaTime);
    }
}