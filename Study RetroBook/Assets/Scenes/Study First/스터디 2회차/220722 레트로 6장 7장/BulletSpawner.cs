using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 1. Random에 대한 설명 - discord정리
 * 2. Instantiate 객체생성
 *  - 단독으로 사용하면, 위치와 회전이 임의x로 생성된다.(정해놓은대로 간다.) 298p 잘못된 내용
 *  - 
 */
public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;     // 생성할 탄알의 원본 프리팹
    public float spawnRateMin = 0.5f;   // 최소 생성 주기
    public float spawnRateMax = 3f;     // 최대 생성 주기

    private Transform target;   // 발사할 대상
    private float spawnRate;    // 생성 주기
    private float timeAfterSpawn;   // 최근 생성 시점에서 지난 시간

    private void Start()
    {
        // 최초 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0;

        // 탄알 생성 간격을 spawnRateMin과 Max사이에 랜덤 지정
        /**
         * Random.Range(시작값, 끝값) : int인 경우. 마지막 값을 포함하지(x), float는 마지막값 포함(o) 
         * Random에 대한 자세한 설명은 Discord에 작성
         */
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        target = FindObjectOfType<PlayerController>().transform;    // 이것도 이름검색하는거랑 비슷하게 별로 안좋다.(책에도 적혀있음)
    }

    private void Update()
    {
        // timeAfterSpawn 갱신
        timeAfterSpawn += Time.deltaTime;

        // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (timeAfterSpawn >= spawnRate)
        {
            // 누적시간 리셋 -> 이런방법 많이 쓴다. 일정시간마다 한번씩 실행할 때 사용한다.
            timeAfterSpawn = 0;

            // 이게 이렇게 소환한다는 의미는, 생성된 오브젝트가 자체의 위치로 생성하지말고, BulletSpawn 스크립트가 달려있는 오브젝트의
            //위치와 방향대로 생성하라는 의미이다.
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);    // 타겟에게 진행

            // 다음번 생성 간격을 랜덤하게 지정하기
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
