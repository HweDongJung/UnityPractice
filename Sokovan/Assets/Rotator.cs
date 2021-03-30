using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update() // 한 프레임당 1번 갱신, 30프레임이면 30번 60프레임이면 60번 이를 방지 하기 위해 시간 간격 곱해줌
    {
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime); // 1초당 원하는 스피드 * 시간단위 deltaTime
    }
}
