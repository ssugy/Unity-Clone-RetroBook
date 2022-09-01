using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Std_Invoke : MonoBehaviour
{
    void Start()
    {
        Invoke("EatPotion", 2);
        InvokeRepeating("EatPotion",0, 1);   
        CancelInvoke();
    }

    int health = 0;
    private void EatPotion()
    {
        health += 10;
        Debug.Log($"����� ü���� {health}�Դϴ�.");
        if (health >= 100)
        {
            CancelInvoke();
        }
    }


    void Update()
    {
        
    }
}
