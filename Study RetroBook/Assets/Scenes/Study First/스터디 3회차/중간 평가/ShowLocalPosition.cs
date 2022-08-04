using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLocalPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print($"{gameObject.name} 월드 포지션은 {transform.position}"
                + "테스트");
        Debug.Log("");
    }

}
