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
        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;   // health 50���� �̰�(and) mana�� 20�����̸� true
        bool isBadCondition = health <= 50 || mana <= 20;   // health 50���� �Ǵ�(or) mana�� 20�����̸� true
        print("����� ���°� ���޴ϱ�? " + isBadCondition);

        // ���� ������
        string condition = isBadCondition ? "����" : "����";
        #endregion

        #region 4. Ű����, 5. ���ǹ�
        // int float string bool new List  �����̸� ��� ����. �����ε� ��� ����

        if (condition == "����")
        {
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }

        if (isBadCondition && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        else if (isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }

        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                print("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                print("���� ���Ͱ� ����!");
                break;
            case "��":
                print("���� ���Ͱ� ����!");
                break;
            default:
                print("??? ���Ͱ� ����!");
                break;
        }

        // C# 7.0������ �߰��� switch����
        // �̰� �ѹ� �� �ڿ� �̷� ���µ� �ֱ��� ������ �Ѿ�ø� �˴ϴ�.
        /**
         * ����ġ�� �� ���̽��� �������� ���Ϸ� �˻��ϴ� �͸� �����Ͽ�����,
         * switch���� ���ϸ�Ī�� ����Ǹ� ������ �ణ ����Ǿ����ϴ�.
         * �׷��� ������ if�� �Ϻθ� ������ switch������ �� �������ʹ� ��� switch���� if�� ���� ���� �����մϴ�.
         */
        int testNum = 10;
        switch (testNum)
        {
            case int i when i > 10:
                print($"{testNum} 10���� ū ���");
                break;
            case int i when i <= 10:
                print($"{testNum} 10���� �۰ų� ���� ���");
                break;
            default:
                break;
        }

        string text = "....";
        switch (text)
        {
            case var item when (item.Contains("http://www.naver.com")):
                print("�뵵�� �����ϱ��?1");
                break;
            case var item when (item.Contains("http://www.daum.net")):
                print("�뵵�� �����ϱ��?2");
                break;
            default:
                print("�뵵�� �����ϱ��?3");
                break;
        }

        // 6.�ݺ���
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("���������� �Ծ����ϴ�.");
            }
            else
            {
                Debug.Log("����Ͽ����ϴ�.");
            }

            if (health == 10)
            {
                print("�ص����� ����մϴ�.");
                break;
            }
        }


        for (int count = 0; count < 10; count++)
        {
            health++;
            print("�ش�� ġ�� ��..." + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            print("�� ������ �ִ� ���� : " + monsters[index]);
        }

        foreach (var item in monsters)
        {
            print("�� ������ �ִ� ���� : " + item);
        }
        #endregion
    }

    #region 7. �Լ� 28:15

    #endregion
}
