using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    private void Start()
    {
        onCalculate = Sum;
        onCalculate += Substract;
        onCalculate -= Substract;
        onCalculate += Multiply;
    }

    public float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }

    public float Substract(float a, float b)
    {
        Debug.Log(a - b);
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onCalculate(1, 10);
        }
    }

}
