using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLocalPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print($"{gameObject.name} ���� �������� {transform.position}"
                + "�׽�Ʈ");
        Debug.Log("");
    }

}
