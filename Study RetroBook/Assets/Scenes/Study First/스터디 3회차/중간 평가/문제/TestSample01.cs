using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSample02 : MonoBehaviour
{
    private List<GameObject> list;

    private void Start()
    {
        // ������ ������Ʈ�� ����ӿ�����Ʈ�� �ڽ����� ����
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

        // 3�� ������Ʈ�� ��Ȱ��ȭ �ϱ�
        foreach (GameObject item in list)
        {
            if (item.name.IndexOf("Monster3") == 3)
            {
                Destroy(item);
            }
        }
    }
}
