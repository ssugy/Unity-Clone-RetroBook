using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        #region 1. 변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        print("용사의 이름은?");
        print(playerName);
        print("용사의 레벨은?");
        print(level);
        print("용사의 힘은?");
        print(strength);
        print("용사는 만렙인가?");
        print(isFullLevel);
        #endregion

        #region 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };

        print("맵에 존재하는 몬스터");
        print(monsters[0]);
        print(monsters[1]);
        print(monsters[2]);

        //몬스터 레벨
        int[] monsterLevels = new int[3];   // 크기를 넣어야 한다.(안넣어도 됨)
        monsterLevels[0] = 1;
        monsterLevels[1] = 6;
        monsterLevels[2] = 20;

        print("맵에 존재하는 몬스터의 레벨");
        print(monsterLevels[0]);
        print(monsterLevels[1]);
        print(monsterLevels[2]);

        List<string> items = new List<string>();    // 여기서 <>안에 있는 부분을 제너릭이라고 한다.
        items.Add("생명물약30");
        items.Add("마나물약30");

        print("가지고 있는 아이템");
        print(items[0]);
        print(items[1]);

        items.RemoveAt(0);  //0번 아이템 삭제

        print(items[0]);
        //print(items[1]);    // 인덱스 에러가 뜬다.
        #endregion

        #region 3. 연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;    // 힘은 레벨에 비례해서 증간한다는 의미.

        print("용사의 총 경험치는?");
        print(exp);
        print("용사의 레벨은?");
        print(level);
        print("용사의 힘은?");
        print(strength);

        int nextExp = 300 - (exp % 300);
        print("다음 레벨까지 남은 경험치는?");
        print(nextExp);

        string title = "전설의";
        print("용사의 이름은?");
        print(title + " " + playerName);

        // 비교 연산자
        int fullLevel = 90;
        isFullLevel = level == fullLevel;
        print("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        print("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        // 논리연산자
        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;   // health 50이하 이고(and) mana가 20이하이면 true
        bool isBadCondition = health <= 50 || mana <= 20;   // health 50이하 또는(or) mana가 20이하이면 true
        print("용사의 상태가 나쁩니까? " + isBadCondition);

        // 삼항 연산자
        string condition = isBadCondition ? "나쁨" : "좋음";
        #endregion

        #region 4. 키워드, 5. 조건문
        // int float string bool new List  변수이름 사용 못함. 값으로도 사용 못함

        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                print("소형 몬스터가 출현!");
                break;
            case "악마":
                print("중형 몬스터가 출현!");
                break;
            case "골렘":
                print("대형 몬스터가 출현!");
                break;
            default:
                print("??? 몬스터가 출현!");
                break;
        }

        // C# 7.0버전에 추가된 switch형태
        // 이건 한번 본 뒤에 이런 형태도 있구나 정도로 넘어가시면 됩니다.
        /**
         * 스위치의 각 케이스는 기존에는 단일로 검사하는 것만 가능하였지만,
         * switch문의 패턴매칭이 적용되며 문법이 약간 변경되었습니다.
         * 그래서 기존에 if의 일부만 가능한 switch문에서 이 버전부터는 모든 switch문이 if로 서로 변경 가능합니다.
         */
        int testNum = 10;
        switch (testNum)
        {
            case int i when i > 10:
                print($"{testNum} 10보다 큰 경우");
                break;
            case int i when i <= 10:
                print($"{testNum} 10보다 작거나 같은 경우");
                break;
            default:
                break;
        }

        string text = "....";
        switch (text)
        {
            case var item when (item.Contains("http://www.naver.com")):
                print("용도가 무엇일까요?1");
                break;
            case var item when (item.Contains("http://www.daum.net")):
                print("용도가 무엇일까요?2");
                break;
            default:
                print("용도가 무엇일까요?3");
                break;
        }

        // 6.반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독데미지를 입었습니다.");
            }
            else
            {
                Debug.Log("사망하였습니다.");
            }

            if (health == 10)
            {
                print("해독제를 사용합니다.");
                break;
            }
        }


        for (int count = 0; count < 10; count++)
        {
            health++;
            print("붕대로 치료 중..." + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            print("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        foreach (var item in monsters)
        {
            print("이 지역에 있는 몬스터 : " + item);
        }
        #endregion
    }

    #region 7. 함수 28:15

    #endregion
}
