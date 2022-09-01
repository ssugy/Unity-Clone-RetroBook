using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Std_ColorChange : MonoBehaviour
{
    public Image img;
    private Color tmpColor;

    private void Start()
    {
        tmpColor = img.color;
        StartCoroutine(ChangeColor());
    }

    private float colorSpeed = 1.0f/200f;
    private float progress = 0;

    IEnumerator ChangeColor()
    {
        while (img.color != Color.magenta)
        {
            progress += colorSpeed;
            tmpColor = Color.Lerp(Color.white, Color.magenta, progress);
            img.color = tmpColor;
            yield return new WaitForSeconds(0.01f);
            Debug.Log("컬러변환");
        }

        progress = 0;
        while (img.color != Color.red)
        {
            progress += colorSpeed;
            tmpColor = Color.Lerp(Color.magenta, Color.red, progress);
            img.color = tmpColor;
            yield return new WaitForSeconds(0.01f);
            Debug.Log("컬러변환");
        }
    }
}
