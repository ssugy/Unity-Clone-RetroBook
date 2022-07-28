using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter10_Move : MonoBehaviour
{
    public Transform childTransForm;    // 움직일 자식 게임 오브젝트의 트렌스폼

    private void Start()
    {
        // me의 전역 위치를 0 -1 0 으로 변경
        transform.position = new Vector3(0, -1, 0);
        // 자식의 지역 위치를 0 2 0으로 변경
        childTransForm.localPosition = new Vector3(0, 2, 0);

        // me의 전역 회전을 0 0 30으로 변경
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        // 자식의 지역 회전을 0 60 0으로 변경
        childTransForm.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // 위쪽 방향키를 누르면 초당 0 1 0의 속도로 평행이동
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 오른쪽 방향키를 누르면
            // me 초당 0 0 -180도 회전
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            childTransForm.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            childTransForm.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }
    }
}
