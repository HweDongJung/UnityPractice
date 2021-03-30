using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCsharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int height = 170;
        float heightDt = 170.6f;

        heightDt = height; //잃어버리는 정보 없으므로 자동 형변환 

        height = (int)heightDt; //잃어버리는 정보 있으므로 직접 명시해서 형변환 

    }

   
}
