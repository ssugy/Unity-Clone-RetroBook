using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private static ObjectPool uniqueInstance;
    public static ObjectPool s_instance { get { return uniqueInstance; } }

    [SerializeField] private GameObject poolingOjbectPrefab;
    private Queue<ball> poolingObjectsQueue = new Queue<ball>(); // ������� ����ϰ� �ϱ� ����

    private void Awake()
    {
        uniqueInstance = this;
    }

    private void Start()
    {
        //Initialize(10); // ó���� 10�� �����α�
    }

    private ball CreateNewObject()
    {
        var newObj = Instantiate(poolingOjbectPrefab, transform).GetComponent<ball>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }

    private void Initialize(int count)
    {
        for (int i = 0; i < count; i++)
        {
            poolingObjectsQueue.Enqueue(CreateNewObject());
        }
    }

    public static ball GetObject()
    {
        // ������ �� �ִ� ������Ʈ�� 1���� ������
        if (ObjectPool.s_instance.poolingObjectsQueue.Count > 0)
        {
            var obj = s_instance.poolingObjectsQueue.Dequeue();
            obj.transform.SetParent(null);
            obj.gameObject.SetActive(true);
            return obj;
        }
        else
        {
            var newObj = s_instance.CreateNewObject();
            newObj.transform.SetParent(null);
            newObj.gameObject.SetActive(true);
            return newObj;
        }
    }

    // �������� ���ӿ�����Ʈ ó�� - �������� �� ��ġ �ʱ�ȭ �ؾߵ�.
    public static void ReturnObject(ball ball)
    {
        ball.transform.SetParent(s_instance.transform);
        ball.gameObject.transform.localPosition = Vector3.up;
        ball.gameObject.SetActive(false);
        s_instance.poolingObjectsQueue.Enqueue(ball);
    }
}
