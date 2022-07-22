using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 1. 스크립트 개선
 *  - 조작이 게임에 즉시 반영되지 않습니다. (힘을 가하는 것이라서 점진적으로 변경됨)
 *  - 입력 감지 코드가 복잡
 *  - rigidbody 드래그/드롭으로 할당하는 것이 불편(나는 별로..)
 * 
 * 2. GetComponent<> : 제너릭 사용
 *  - 만약 사용안하면
 *  - GetComponentRigidbody(), GetComponentTransform()... 이렇게 아주 많은 개별타입에 맞춘 함수를 각각 만들어야된다.(그렇게 할 수 없음)
 *  
 * 3. Addforce, velocity차이
 *  - Addforce : 힘을 주는 것 이기 때문에, 관성이 존재합니다.
 *  - velocity : 속도가 즉각적으로 변합니다.
 */
public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        /*
         * 최초의 방법 - 비효율적이다, 코드가 너무 길다.
        // GetKey : 사용자가 키를 누르고 있는 동안 true
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0, 0);
        }
        */

        // 지금 이런코드 상당히 문제가 있는게, update내부에서는 변수나 객체를 생성하는게
        //아주 안좋은 습관이다. 이거 외부변수로 빼야되는데, 우선 책에 있는대로 따라가겠다.
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // vector3 속도를 (xspeed, 0 , zspeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // rigidbody 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);    // 오브젝트 비활성화
    }
}
