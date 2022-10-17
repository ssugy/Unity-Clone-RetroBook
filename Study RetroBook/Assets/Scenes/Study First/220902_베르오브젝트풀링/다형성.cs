using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 다형성 : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog();
        dog.Sound(); // 동물소리

        IAnimal dog2 = new Dog();    //다형성
        dog2.Sound();   //머가나오냐? -> 동물소리
       
    }
}

interface IAnimal
{
    public void Sound();
}

class Dog : IAnimal
{
    public void Sound()
    {
        System.Console.WriteLine("왈왈");
    }
}

