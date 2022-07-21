using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    //private int id; // 유니티는 기본으로 private형태로 지정되어있다. public으로 바꾸어야지 사용 가능하다.
    public int id; // 유니티는 기본으로 private형태로 지정되어있다. public으로 바꾸어야지 사용 가능하다.
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
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
