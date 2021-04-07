using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour //추상클래스
{
    public float damage = 100f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    //완전한 형태의 함수와 추상형 함수 전부 가질 수 있음 
    public abstract void Attack();
    
}
