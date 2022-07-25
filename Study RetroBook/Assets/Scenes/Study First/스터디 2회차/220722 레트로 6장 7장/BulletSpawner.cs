using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 1. Random�� ���� ���� - discord����
 * 2. Instantiate ��ü����
 *  - �ܵ����� ����ϸ�, ��ġ�� ȸ���� ����x�� �����ȴ�.(���س������ ����.) 298p �߸��� ����
 *  - 
 */
public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;     // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;   // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;     // �ִ� ���� �ֱ�

    private Transform target;   // �߻��� ���
    private float spawnRate;    // ���� �ֱ�
    private float timeAfterSpawn;   // �ֱ� ���� �������� ���� �ð�

    private void Start()
    {
        // ���� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0;

        // ź�� ���� ������ spawnRateMin�� Max���̿� ���� ����
        /**
         * Random.Range(���۰�, ����) : int�� ���. ������ ���� ��������(x), float�� �������� ����(o) 
         * Random�� ���� �ڼ��� ������ Discord�� �ۼ�
         */
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        target = FindObjectOfType<PlayerController>().transform;    // �̰͵� �̸��˻��ϴ°Ŷ� ����ϰ� ���� ������.(å���� ��������)
    }

    private void Update()
    {
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            // �����ð� ���� -> �̷���� ���� ����. �����ð����� �ѹ��� ������ �� ����Ѵ�.
            timeAfterSpawn = 0;

            // �̰� �̷��� ��ȯ�Ѵٴ� �ǹ̴�, ������ ������Ʈ�� ��ü�� ��ġ�� ������������, BulletSpawn ��ũ��Ʈ�� �޷��ִ� ������Ʈ��
            //��ġ�� ������ �����϶�� �ǹ��̴�.
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);    // Ÿ�ٿ��� ����

            // ������ ���� ������ �����ϰ� �����ϱ�
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
