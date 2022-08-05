using UnityEngine;

/**
 * 이게 뭔소린가 했네.. 게임 기획에서 어떠한 게임인지 정확하게 이해하고 개발을 진행해야 한다.
 * 1. 현재 이 게임은 바닥에 올라갈 때마다 점수가 추가된다.
 * 2. 같은 바닥이면 추가적으로 점수가 올라가는 것은 없다.
 * 3. 중복 점수 상승을 막기 위해 Stepped 변수를 만들었고, 바닥에 올라갈 때 딱 한번 점수를 얻는다.
 * 3. 장애물(삼각형 모양)에 부딧히면 죽는다.
 */
public class Platform : MonoBehaviour {
    public GameObject[] obstacles; // 장애물 오브젝트들
    private bool stepped = false; // 이게 뭔소린가 했네. 

    // 컴포넌트가 활성화될때 마다 매번 실행되는 메서드
    public void OnEnable() {

        // 발판을 리셋하는 처리
        stepped = false;

        // 장애물의 수만큼 루프
        for (int i = 0; i < obstacles.Length; i++)
        {
            // 장애물 각각을 1/3확률로 활성화
            if (Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }

            obstacles[i].SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        // 플레이어 캐릭터가 자신(장애물)을 밟았을때 점수를 추가하는 처리

        if (collision.gameObject.CompareTag("Player") && !stepped)
        {
            stepped = true; //중복점수 막기
            GameManager.instance.AddScore(1);
        }
    }
}