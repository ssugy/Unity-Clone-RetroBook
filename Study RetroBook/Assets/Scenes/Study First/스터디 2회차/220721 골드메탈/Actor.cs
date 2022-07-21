using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    //private int id; // ����Ƽ�� �⺻���� private���·� �����Ǿ��ִ�. public���� �ٲپ���� ��� �����ϴ�.
    public int id; // ����Ƽ�� �⺻���� private���·� �����Ǿ��ִ�. public���� �ٲپ���� ��� �����ϴ�.
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "��ȭ�� �ɾ����ϴ�.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level += 1;
    }
}
