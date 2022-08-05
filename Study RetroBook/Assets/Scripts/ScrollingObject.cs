using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour {
    static public float speed = 5f; // 이동 속도, 이게임 웃긴게 속도를 기준으로 점프공간 이런걸 다 연결해놔서, 바닥 생성도 속도기준으로 변경예정

    private void Start()
    {
        speed = 5f;    // 모든곳에서 등속으로 함.
    }

    private void Update() {

        if (!GameManager.instance.isGameover)
        {
            // 초당 speed의 속도로 왼쪽으로 평행이동
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}