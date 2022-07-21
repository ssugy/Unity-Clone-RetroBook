using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * https://luv-n-interest.tistory.com/723 : 접근제한자 기본적인 내용
 * 1. 접근제한자(public, private, protected, internal)
 *  1) public : 모든 곳에서 해당 멤버로 접근이 가능.
 *  2) private  : 동일한 클래스, 동일한 구조체 내에서만 접근이 가능.
 *  3) protected : 클래스 외부에서는 접근할 수 없으나, 파생 클래스(상속받은 클래스)에서는 접근 가능
 *   - 파생(Derived) 클래스
 *   - 상속된(inherited) 클래스
 *   - 용어정리 : 상속을 사용할 때 상속되는(inherited) 클래스를 기본 클래스라고 하고 상속받는(inheriting) 클래스를 파생 클래스라고 합니다.
 *   - https://stackoverflow.com/questions/2077097/oop-difference-between-a-derived-class-and-an-inherited-class
 *  4) internal : 같은 어셈블리에서만 접근 가능
 *   - 어셈블리 : 프로젝트를 컴파일해서 exe, dll로 묶이는 단위를 말합니다(exe는 진입점(Main함수)이 있는 . 
 *                같은 프로젝트는 일반적으로 같은 어셈블리를 가지게 됩니다.
 *   - internal 접근자는, 같은 어셈블리 내에서는 public, 다른 어셈블리에서는 private효과를 주는 역할이며, 보통 Helper Class를 제작하는데에 사용된다.
 *   - https://m.cafe.daum.net/csharp-novice/5ijJ/47?listURI=%2Fcsharp-novice%2F5ijJ : 어셈블리 기본 설명
 *   - https://slaner.tistory.com/69 : internal 클래스 예제.
 *   
 *   * 추가 : protected internal이라는 한정자가 존재하며, 어셈블리 내의 상속 클래스에서만 접근 가능합니다.
 */
public class Chapter5_Animal
{
    public string name;
    public string sound;

    public void PlaySound()
    {
        //System.Console.WriteLine(); 이걸로는 Unity콘솔창에서 작동안함.
        Debug.Log($"{name} : {sound}");
    }
}

#region Protected 설명 예제
// 기본클래스 A
class A
{
    protected int x = 123;
}

// A로부터 파생된, B 클래스.
class B : A
{
    static void Main()
    {
        var a = new A();
        var b = new B();

        // Error CS1540, 
        // x변수는 A클래스의 파생 클래스에서만 접근이 가능하기 때문에 아래는 에러.
        // a.x = 10;

        // OK. B클래스는 A로부터 파생(상속과 유사)
        b.x = 10;
    }
}
#endregion
