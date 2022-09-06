using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

/**
 * ������Ʈ Ǯ���� 2021������ ���ı������ ä�õ�.
 */
public class ball : MonoBehaviour
{
    private Vector3 ballDir;
    private IObjectPool<ball> managedPool;
    
    public void SetManagedPool(IObjectPool<ball> pool)
    {
        managedPool = pool;
    }

    public void Shooter(Vector3 dir)
    {
        ballDir = dir;
        Invoke("DestoryBall", 5);
    }

    private void DestoryBall()
    {
        //Destroy(gameObject);
        //ObjectPool.ReturnObject(this);
        managedPool.Release(this);
    }

    private void Update()
    {
        transform.Translate(ballDir * Time.deltaTime);
    }
}
