using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Chapter8_GameManager : MonoBehaviour
{
    public GameObject gameOverTextObj; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ(���� �ִ�), ���̶�Ű���� �̸� ����
    public TextMeshProUGUI timeText;    // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public TextMeshProUGUI recordText;  // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;  // �����ð�(���ӽ��� ���� ������� �÷��̾� ��Ƴ��� �ð�)
    private bool isGameOver;    // ���ӿ��� ����

    private void Start()
    {
        surviveTime = 0;
        isGameOver = false;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            // �����ð� ����
            surviveTime += Time.deltaTime;
            // ������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��ؼ� ǥ��
            //timeText.text = $"Time: {surviveTime.ToString("F1")}";    // �Ҽ� ù°�ڸ� ���� ǥ��
            timeText.text = $"Time : {(int)surviveTime}";
        }
        else
        {
            // ���ӿ������¿��� RŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                print("����  ");
                SceneManager.LoadScene("chapter6"); // ���Ŵ��� �߰��Ϸ��� using UnityEngine.SceneManagement; �ʿ��ϴ�
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("test");
            Vector3 A = new Vector3(1, 1, 0);
            Vector3 B = new Vector3(1, 0, 0);
            print("�ڽ� : " + Mathf.Rad2Deg * Mathf.Acos(Vector3.Dot(A, B)/(A.magnitude*B.magnitude)));
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

        // ���� ������ �б�/����, SetFloat/GetFloat
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", surviveTime);
        }

        // �ְ� ����� recordTextǥ��
        recordText.text = $"Best Time : {(int)bestTime}";
    }
}
