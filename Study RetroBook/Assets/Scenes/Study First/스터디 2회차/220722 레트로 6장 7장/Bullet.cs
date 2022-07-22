using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Destroy는 비용이 높은 작업이다.
 * 오브젝트 풀링의 개념에서는 디스트로이 하지 않고, 다른곳으로 옮기거나, SetActive로 껏다가 켜는 방식이 좋다.
 * 
 * OnTrigger 체크는 둘중 하나만 Trigger라면 Collider 이벤트가 아니라 Trigger이벤트가 발생한다.
 */
public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidBody;  // 총알 이동에 사용할 리지드바디

    private void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
        bulletRigidBody.velocity = transform.forward * speed;   // 블루라인이니까 RGB Z축 이동임

        // 자동 삭제
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 상대방 태그가 Player태그라면
        if (other.CompareTag("Player"))
        {
            // 상대방의 PlayterController 가져온다.
            PlayerController playerController = other.GetComponent<PlayerController>();

            // 상대방의 PlayerController를 제대로 가져왔다면,
            if (playerController != null)
            {
                playerController.Die(); // Die()함수 실행
            }
        }
    }
    
}
