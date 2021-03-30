using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 주석 
        /*
         * 주
         * 석
         * 
         */

        Debug.Log("안녕"); //콘솔 출력

        int age =12;
        int money = 10000;
        Debug.Log(age);
        Debug.Log(money);

        //float -> 32비트, 7자리까지만 정확 
        float height = 169.3243f;
        //double -> 두배 64비트, 15자리까지만 정확 
        double pi = 3.14159265359;
        string str = "러브라이브!"; //문자열 
        bool is_boy = true;

        Debug.Log("내 키는 " + height + "\n");
        Debug.Log("젠카이노 " + str + "\n");
        Debug.Log("원주율이 궁금해? " + pi + "야!\n");
        Debug.Log("나는 남자? " + is_boy);

        var name = "나는 잼민이"; // var은 c++의 auto와 비슷함 
        Debug.Log("\n" + name);
    }

  
}
