using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotator : MonoBehaviour
{
    public float speed = 60f;

    void Update()
    {
        Rotate();
    }

    protected virtual void Rotate() //virtual 가상으로 선언하고 자식들이 함수 내부를 덮어씌움 
    {
        
    }
}
