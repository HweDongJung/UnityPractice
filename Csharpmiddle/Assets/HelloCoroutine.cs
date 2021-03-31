using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("HelloUnity");
        StartCoroutine(HelloCsharp());
        Debug.Log("End");
        //보통의 경우 위에 함수가 끝나고 아랫함수가 시작되는데 코루틴 함수의 경우 잠깐 yeild return시 다음 함수로 바톤터치 -> 비동기식 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StopCoroutine("HelloUnity");
        }
    }

    IEnumerator HelloUnity()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("Hello Unity");
        }
        
    }

    IEnumerator HelloCsharp()
    {
        Debug.Log("Hello");
        yield return new WaitForSeconds(5f);
        Debug.Log("Csharp");

    }
}
