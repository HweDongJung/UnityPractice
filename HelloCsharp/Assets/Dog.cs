using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string nickName;
    public float weight;
    public static int count = 0;//세상에 존재하는 개의 수

    private void Awake()
    {
        count++;
    }

    private void Start()
    {
        Bark();
    }
    public void Bark()
    {
        Debug.Log("모든 개들의 수: " + count);
        Debug.Log(nickName + " Bark!");
    
    }
}
