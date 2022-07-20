using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        #region 1. ����
        int level = 5;
        float strength = 15.5f;
        string playerName = "���˻�";
        bool isFullLevel = false;

        print("����� �̸���?");
        print(playerName);
        print("����� ������?");
        print(level);
        print("����� ����?");
        print(strength);
        print("���� �����ΰ�?");
        print(isFullLevel);
        #endregion

        #region 2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };

        print("�ʿ� �����ϴ� ����");
        print(monsters[0]);
        print(monsters[1]);
        print(monsters[2]);

        //���� ����
        int[] monsterLevels = new int[3];   // ũ�⸦ �־�� �Ѵ�.(�ȳ־ ��)
        monsterLevels[0] = 1;
        monsterLevels[1] = 6;
        monsterLevels[2] = 20;

        print("�ʿ� �����ϴ� ������ ����");
        print(monsterLevels[0]);
        print(monsterLevels[1]);
        print(monsterLevels[2]);

        List<string> items = new List<string>();    // ���⼭ <>�ȿ� �ִ� �κ��� ���ʸ��̶�� �Ѵ�.
        items.Add("������30");
        items.Add("��������30");

        print("������ �ִ� ������");
        print(items[0]);
        print(items[1]);

        items.RemoveAt(0);  //0�� ������ ����

        print(items[0]);
        //print(items[1]);    // �ε��� ������ ���.
        #endregion

        #region 3. ������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;    // ���� ������ ����ؼ� �����Ѵٴ� �ǹ�.

        print("����� �� ����ġ��?");
        print(exp);
        print("����� ������?");
        print(level);
        print("����� ����?");
        print(strength);

        int nextExp = 300 - (exp % 300);
        print("���� �������� ���� ����ġ��?");
        print(nextExp);

        string title = "������";
        print("����� �̸���?");
        print(title + " " + playerName);

        // �� ������
        int fullLevel = 90;
        isFullLevel = level == fullLevel;
        print("���� �����Դϱ�? " + isFullLevel);

        bool isEndTutorial = level > 10;
        print("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);

        // ��������
        
        #endregion


    }
}
