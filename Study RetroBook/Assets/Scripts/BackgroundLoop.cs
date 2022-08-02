using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    private void Awake() {
        // 가로 길이를 측정하는 처리
        // 아니 가로길이를 왜 콜라이더 써서 구하는거지? 그냥 sprite상태에서 못구하나?
        // 구할수있음. 이런데 쓰라고 SpriteRenderer에 size프로퍼티가 붙어있는 것임.
        print(GetComponent<SpriteRenderer>().size);
        width = GetComponent<SpriteRenderer>().size.x;
    }

    private void Update() {
        // 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 리셋
        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }

    // 위치를 리셋하는 메서드
    private void Reposition() {
        // 현재 위치에서 오른쪽으로 가로길이 * 2 만큼 이동 - 이미지 2개 이어붙일거라서 괜찮음.
        // 굳이 형변환말고 vecto3로 진행.
        Vector3 offset = new Vector3(width * 2, 0, 0);
        transform.position += offset;
    }
}