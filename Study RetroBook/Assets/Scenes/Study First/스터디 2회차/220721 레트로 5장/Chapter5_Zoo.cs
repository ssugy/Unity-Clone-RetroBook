using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 1. MonoBehaviour를 상속한 클래스는 new로 생성하지 못한다.
 * 2. MonoBehaviour를 상속한 클래스는 컴포넌트로 동작하며, 게임오브젝트에 추가가 가능하다.
 * 3. 참조변수의 대입 - jerry = tom은 직관적으로 생각하는 값의 복사가 아니라, 가리키는 대상의 변경입니다.
 */
public class Chapter5_Zoo : MonoBehaviour
{
    void Start()
    {
        Chapter5_Animal tom = new();
        tom.name = "톰";
        tom.sound = "냐옹";   // private로 변경하면 접근 불가능

        Chapter5_Animal jerry = new();  // heap에서의 메모리 할당 과정.
        jerry.name = "제리";
        jerry.sound = "찍찍";

        // 참조를 한 것이기 때문에, 각각이 서로 다른 공간(heap에서의 메모리)를 점유하고 있다.
        tom.PlaySound();
        jerry.PlaySound();

        #region 참조변수 대입
        jerry = tom;    // 값을 덮어씌우는게 아니라, 참조하는 대상을 변경한 것입니다.

        jerry.name = "미키";

        jerry.PlaySound();  // 미키, 냐옹
        tom.PlaySound();    // 미키, 냐옹 (여기도 변경됨)
        #endregion
    }
}
