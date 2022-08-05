using UnityEngine;

// 발판을 생성하고 주기적으로 재배치하는 스크립트
/**
 * 아니 누가 발판생성을 고정 시간값의 랜덤으로 만드는거임? 아놔..이러면 속도 변경하거나 커스텀하게 뭐라도 건드리면 고정수치값 다 바꿔야되는것임.
 */
public class PlatformSpawner : MonoBehaviour {
    public GameObject platformPrefab; // 생성할 발판의 원본 프리팹
    public int count = 3; // 생성할 발판의 개수

    public float timeBetSpawnMin = 1.25f; // 다음 배치까지의 시간 간격 최솟값
    public float timeBetSpawnMax = 2.25f; // 다음 배치까지의 시간 간격 최댓값
    private float timeBetSpawn; // 다음 배치까지의 시간 간격

    public float yMin = -3.5f; // 배치할 위치의 최소 y값
    public float yMax = 1.5f; // 배치할 위치의 최대 y값
    private float xPos = 20f; // 배치할 위치의 x 값

    private GameObject[] platforms; // 미리 생성한 발판들
    private int currentIndex = 0; // 사용할 현재 순번의 발판

    private Vector2 poolPosition = new Vector2(0, -20); // 초반에 생성된 발판들을 화면 밖에 숨겨둘 위치
    private float lastSpawnTime; // 마지막 배치 시점


    void Start() {
        // 변수들을 초기화하고 사용할 발판들을 미리 생성
        platforms = new GameObject[count];  // 그렇지 이때 초기화 하니까 여기서 다 널로 바뀜. 코드로 넣어야됨

        // count만큼 루프하면서 발판 생성
        for (int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
            //print(platforms[i].transform.position);
        }

        // 마지막 배치 시점 초기화
        lastSpawnTime = 0f;
        // 다음번 배치까지의 시간 간격을 0으로 초기화
        timeBetSpawn = 0;
    }

    void Update() {
        // 게임오버 상태에서는 동작하지 않음
        if (GameManager.instance.isGameover)
        {
            return;
        }

        // 마지막 배치 시점에서 timeBetSpawn 이상 시간이 흘렀다면
        // 타이머 함수를 사용함. Time.time은 게임시작후 현재까지 진행된 시간을 초단위 숫자로 알려준다.(멈추지 않으면 계속 증가하는 값임)
        //if (Time.time >= lastSpawnTime + timeBetSpawn)    // 이게 왜 잠깐 헷갈렸는지 알았다. 순서의 문제임
        //그리고 이거 이런식으로 고정시간값으로 하면 안되는게, 게임 플레이어의 속도가 변경되면 이 시간도 다 바뀌어야함. 그래서 이렇게 하는게 아니라, 보통 
        //트리거 달아서 트리거에서 지정함.
        if (lastSpawnTime + timeBetSpawn <= Time.time)  // 이게 난 더 이해하기 편함
        {
            // 기록된 마지막 배치 시점을 현재 시점으로 갱신 - 이러면 betspawn타임마다 한번씩 실행된다.
            lastSpawnTime = Time.time;

            // 다음 배치까지의 시간 간격을 랜덤하게 설정
            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax) * 10 * (1/ScrollingObject.speed);  

            // 배치할 위치의 높이를 yMin과 yMax사이에서 랜덤 설정
            float yPos = Random.Range(yMin, yMax * 2);
            platforms[currentIndex].gameObject.transform.position = new Vector2(xPos, yPos);

            // 사용할 현재 순번의 발판 게임 오브젝트를 비활성화하고, 즉시 다시 활성화
            // 이때 발판의 platform 컴포넌트의 OnEnable 메서드가 활성화됨
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);    // 아니.. 이거 무슨 Enable을 굳이 하겠다고 이런식으로 깜박거리게 행동하는거지..? 아놔..
            //platforms[currentIndex].GetComponent<Platform>().OnEnable(); // 아니 차라리 enable을 public으로 변경하고 이렇게 하던가. 무슨 깜박거리고 있어..

            // 순번 넘기기
            currentIndex++;

            // 마지막 순번에 도착했다면 순번을 리셋
            if (currentIndex >= count)
            {
                currentIndex = 0;
            }

            //이것도 그냥 삼항연산자로 줄이 수 있다.
            //currentIndex = ++currentIndex >= count ? 0 : currentIndex;
        }
    }
}