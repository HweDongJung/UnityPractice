using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{

    public Image fadeImage;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void FadeIn() // 이렇게 구현하면 서서이 페이드인 되는 것을 못봄(연산이 순식간에 진행되기 때문이다) 따라서 코 루틴을 사용해야함 
    //{
    //    Color startColor = fadeImage.color;

    //    for (int i = 0; i < 100; i++)
    //    {
    //        startColor.a = startColor.a - 0.01f;
    //        fadeImage.color = startColor;
    //    }
    
    //}

    IEnumerator FadeIn() // 코 루틴(corutine)으로 C#의 문법이 아닌 유니티만의 문법이다 
    {
        Color startColor = fadeImage.color;

        for (int i = 0; i < 100; i++)
        {
            startColor.a = startColor.a - 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }


    }
}
