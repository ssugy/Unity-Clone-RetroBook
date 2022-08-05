using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeTest : MonoBehaviour
{
    //public int num1;
    //private int num2;
    //protected int num3;
    //internal int num4;
    //static public int num5;
    //const int num6 = 5;
    //readonly int num7;
    //[HideInInspector] public int num8;
    //[SerializeReference] private int num9;

    private void Start()
    {
        int n = 1;
        n++;

        Debug.Log(++n);
        
        if (n++ > 3 && --n < 5)
            Debug.Log("1번 선택지" + n);
        else
            Debug.Log("2번 선택지" + n);
    }
}
