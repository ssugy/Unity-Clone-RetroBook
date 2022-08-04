using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSample02 : MonoBehaviour
{
    private List<GameObject> list;

    private void Start()
    {
        // 생성된 오브젝트를 빈게임오브젝트의 자식으로 지정
        GameObject monsterParent = new GameObject("Mob");
        monsterParent.transform.position = Vector3.forward;

        for (int i = 1; i <= 20; i++)
        {
            GameObject go = new GameObject();
            go.tag = "Monster";
            go.layer = 40;   
            go.name = "Monster_" + i;
            go.transform.position = new Vector3(Random.Range(0, 10)
                                                , Random.Range(0, 10)
                                                , Random.Range(0, 10));
            list.Contains(go);

            go.transform.SetParent(monsterParent.transform, false);
        }

        // 3번 오브젝트를 비활성화 하기
        foreach (GameObject item in list)
        {
            if (item.name.IndexOf("Monster3") == 3)
            {
                Destroy(item);
            }
        }
    }
}
