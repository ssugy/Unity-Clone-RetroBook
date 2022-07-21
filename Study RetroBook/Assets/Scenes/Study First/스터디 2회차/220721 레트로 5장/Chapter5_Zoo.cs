using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 1. MonoBehaviour�� ����� Ŭ������ new�� �������� ���Ѵ�.
 * 2. MonoBehaviour�� ����� Ŭ������ ������Ʈ�� �����ϸ�, ���ӿ�����Ʈ�� �߰��� �����ϴ�.
 * 3. ���������� ���� - jerry = tom�� ���������� �����ϴ� ���� ���簡 �ƴ϶�, ����Ű�� ����� �����Դϴ�.
 */
public class Chapter5_Zoo : MonoBehaviour
{
    void Start()
    {
        Chapter5_Animal tom = new();
        tom.name = "��";
        tom.sound = "�Ŀ�";   // private�� �����ϸ� ���� �Ұ���

        Chapter5_Animal jerry = new();  // heap������ �޸� �Ҵ� ����.
        jerry.name = "����";
        jerry.sound = "����";

        // ������ �� ���̱� ������, ������ ���� �ٸ� ����(heap������ �޸�)�� �����ϰ� �ִ�.
        tom.PlaySound();
        jerry.PlaySound();

        #region �������� ����
        jerry = tom;    // ���� �����°� �ƴ϶�, �����ϴ� ����� ������ ���Դϴ�.

        jerry.name = "��Ű";

        jerry.PlaySound();  // ��Ű, �Ŀ�
        tom.PlaySound();    // ��Ű, �Ŀ� (���⵵ �����)
        #endregion
    }
}
