using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 1. ��ũ��Ʈ ����
 *  - ������ ���ӿ� ��� �ݿ����� �ʽ��ϴ�. (���� ���ϴ� ���̶� ���������� �����)
 *  - �Է� ���� �ڵ尡 ����
 *  - rigidbody �巡��/������� �Ҵ��ϴ� ���� ����(���� ����..)
 * 
 * 2. GetComponent<> : ���ʸ� ���
 *  - ���� �����ϸ�
 *  - GetComponentRigidbody(), GetComponentTransform()... �̷��� ���� ���� ����Ÿ�Կ� ���� �Լ��� ���� �����ߵȴ�.(�׷��� �� �� ����)
 *  
 * 3. Addforce, velocity����
 *  - Addforce : ���� �ִ� �� �̱� ������, ������ �����մϴ�.
 *  - velocity : �ӵ��� �ﰢ������ ���մϴ�.
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
         * ������ ��� - ��ȿ�����̴�, �ڵ尡 �ʹ� ���.
        // GetKey : ����ڰ� Ű�� ������ �ִ� ���� true
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

        // ���� �̷��ڵ� ����� ������ �ִ°�, update���ο����� ������ ��ü�� �����ϴ°�
        //���� ������ �����̴�. �̰� �ܺκ����� ���ߵǴµ�, �켱 å�� �ִ´�� ���󰡰ڴ�.
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // vector3 �ӵ��� (xspeed, 0 , zspeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // rigidbody �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);    // ������Ʈ ��Ȱ��ȭ
    }
}
