using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Chapter8_GameManager : MonoBehaviour
{
    public GameObject gameOverTextObj; // 게임오비 시 활성화할 텍스트 게임 오브젝트(껏다 켯다), 하이라키에서 미리 꺼둠
    public TextMeshProUGUI timeText;    // 생존 시간을 표시할 텍스트 컴포넌트
    public TextMeshProUGUI recordText;  // 최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime;  // 생존시간(게임시작 이후 현재까지 플레이어 살아남은 시간)
    private bool isGameOver;    // 게임오버 상태

    private void Start()
    {
        surviveTime = 0;
        isGameOver = false;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            // 생존시간 갱신
            surviveTime += Time.deltaTime;
            // 갱신한 생존 시간을 timeText 텍스트 컴포넌트를 이용해서 표시
            //timeText.text = $"Time: {surviveTime.ToString("F1")}";    // 소수 첫째자리 까지 표시
            timeText.text = $"Time : {(int)surviveTime}";
        }
        else
        {
            // 게임오버상태에서 R키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                print("실행  ");
                SceneManager.LoadScene("chapter6"); // 씬매니저 추가하려면 using UnityEngine.SceneManagement; 필요하다
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("test");
            Vector3 A = new Vector3(1, 1, 0);
            Vector3 B = new Vector3(1, 0, 0);
            print("코스 : " + Mathf.Rad2Deg * Mathf.Acos(Vector3.Dot(A, B)/(A.magnitude*B.magnitude)));
            print(Mathf.Rad2Deg *Mathf.Atan2((A-B).y, (A-B).x));


            float Dot = Vector3.Dot(A, B) * 1.0f;
            float Angle = Mathf.Acos(Dot) * 1.0f;
            print(Mathf.Acos(Vector3.Dot(A, B)));

        }
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverTextObj.SetActive(true);

        // 적은 데이터 읽기/쓰기, SetFloat/GetFloat
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // 이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", surviveTime);
        }

        // 최고 기록을 recordText표기
        recordText.text = $"Best Time : {(int)bestTime}";
    }
}
