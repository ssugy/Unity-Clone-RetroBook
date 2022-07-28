using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Destroy�� ����� ���� �۾��̴�.
 * ������Ʈ Ǯ���� ���信���� ��Ʈ���� ���� �ʰ�, �ٸ������� �ű�ų�, SetActive�� ���ٰ� �Ѵ� ����� ����.
 * 
 * OnTrigger üũ�� ���� �ϳ��� Trigger��� Collider �̺�Ʈ�� �ƴ϶� Trigger�̺�Ʈ�� �߻��Ѵ�.
 */
public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidBody;  // �Ѿ� �̵��� ����� ������ٵ�

    private void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
        bulletRigidBody.velocity = transform.forward * speed;   // �������̴ϱ� RGB Z�� �̵���

        // �ڵ� ����
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���� �±װ� Player�±׶��
        if (other.CompareTag("Player"))
        {
            // ������ PlayterController �����´�.
            Chapter6_PlayerController playerController = other.GetComponent<Chapter6_PlayerController>();

            // ������ PlayerController�� ����� �����Դٸ�,
            if (playerController != null)
            {
                playerController.Die(); // Die()�Լ� ����
            }
        }
    }
    
}
