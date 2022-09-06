using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

/**
 * 1. ���콺�� ����� Ŭ���ϸ�, �ش� ����� �������� ball�� �߻��Ѵ�.
 */
public class Shooter : MonoBehaviour
{
    public GameObject ball; //������ ball

    private Vector3 ballDir;
    private Rigidbody ballRigidbody;

    private IObjectPool<ball> ballPool;

    private void Awake()
    {
        ballPool = new ObjectPool<ball>(CreateBullet, OnGetBullet, OnReleaseBullet, OnDestroyBullet, maxSize:20);  //�̷��� ����ϴ°� 2021���. ���⿡ �Ķ���� ��� ä����ߵȴ�.
    }
    private void Update()
    {
        // ������ ���� ���ϰ� �ϱ�
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            LayerMask layerMask = 1 << 7;
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity ,layerMask))
            {
                ballDir = hitInfo.point.normalized;

                //ballRigidbody = Instantiate(ball, ballDir + Vector3.up, Quaternion.identity).GetComponent<Rigidbody>();   //������ƮǮ������ ����
                //var ball = ObjectPool.GetObject();  // ���� Queue�� ����� ������Ʈ Ǯ��
                //ballRigidbody = ball.GetComponent<Rigidbody>(); // ������Ʈ Ǯ�� �� �� ������ ��� ball���� ��� �ðܾߵȴ�.
                //ballRigidbody.velocity = ballDir;

                var ball = ballPool.Get();
                ball.transform.position = transform.position + ballDir;
                ball.Shooter(ballDir);
            }
        }
    }

    // ������Ʈ Ǯ�� ���� �� �����ؾߵǴ� ����
    //1. �����ؼ� ������Ʈ Ǯ ����(ball�� ���߿� ���� ���ƿ��� Ǯ����ü ����)
    private ball CreateBullet()
    {
        ball bullet = Instantiate(ball).GetComponent<ball>();
        bullet.SetManagedPool(ballPool);
        return bullet;
    }

    private void OnGetBullet(ball bullet)
    {
        bullet.gameObject.SetActive(true);
    }

    private void OnReleaseBullet(ball bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    private void OnDestroyBullet(ball bullet)
    {
        Destroy(bullet.gameObject);
    }
}
