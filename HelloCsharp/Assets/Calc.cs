using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(1,1));
        Debug.Log(Sum(1, 2, -4));
        Debug.Log(Sum(1.2f,3));
    }


    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    public float Sum(float a, float b)
    {
        return a + b;
    }
}
