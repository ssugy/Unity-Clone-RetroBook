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
        
        #endregion


    }
}
