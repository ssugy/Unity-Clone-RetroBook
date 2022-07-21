using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * https://luv-n-interest.tistory.com/723 : ���������� �⺻���� ����
 * 1. ����������(public, private, protected, internal)
 *  1) public : ��� ������ �ش� ����� ������ ����.
 *  2) private  : ������ Ŭ����, ������ ����ü �������� ������ ����.
 *  3) protected : Ŭ���� �ܺο����� ������ �� ������, �Ļ� Ŭ����(��ӹ��� Ŭ����)������ ���� ����
 *   - �Ļ�(Derived) Ŭ����
 *   - ��ӵ�(inherited) Ŭ����
 *   - ������� : ����� ����� �� ��ӵǴ�(inherited) Ŭ������ �⺻ Ŭ������� �ϰ� ��ӹ޴�(inheriting) Ŭ������ �Ļ� Ŭ������� �մϴ�.
 *   - https://stackoverflow.com/questions/2077097/oop-difference-between-a-derived-class-and-an-inherited-class
 *  4) internal : ���� ����������� ���� ����
 *   - ����� : ������Ʈ�� �������ؼ� exe, dll�� ���̴� ������ ���մϴ�(exe�� ������(Main�Լ�)�� �ִ� . 
 *                ���� ������Ʈ�� �Ϲ������� ���� ������� ������ �˴ϴ�.
 *   - internal �����ڴ�, ���� ����� �������� public, �ٸ� ����������� privateȿ���� �ִ� �����̸�, ���� Helper Class�� �����ϴµ��� ���ȴ�.
 *   - https://m.cafe.daum.net/csharp-novice/5ijJ/47?listURI=%2Fcsharp-novice%2F5ijJ : ����� �⺻ ����
 *   - https://slaner.tistory.com/69 : internal Ŭ���� ����.
 *   
 *   * �߰� : protected internal�̶�� �����ڰ� �����ϸ�, ����� ���� ��� Ŭ���������� ���� �����մϴ�.
 */
public class Chapter5_Animal
{
    public string name;
    public string sound;

    public void PlaySound()
    {
        //System.Console.WriteLine(); �̰ɷδ� Unity�ܼ�â���� �۵�����.
        Debug.Log($"{name} : {sound}");
    }
}

#region Protected ���� ����
// �⺻Ŭ���� A
class A
{
    protected int x = 123;
}

// A�κ��� �Ļ���, B Ŭ����.
class B : A
{
    static void Main()
    {
        var a = new A();
        var b = new B();

        // Error CS1540, 
        // x������ AŬ������ �Ļ� Ŭ���������� ������ �����ϱ� ������ �Ʒ��� ����.
        // a.x = 10;

        // OK. BŬ������ A�κ��� �Ļ�(��Ӱ� ����)
        b.x = 10;
    }
}
#endregion
