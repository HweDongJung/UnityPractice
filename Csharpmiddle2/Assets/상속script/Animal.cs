using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public string name;
    public float weight;
    public int year;

    public void print()
    {
        Debug.Log(name + " 몸무게: " + weight + " 나이: " + year);
    }

    protected float GetSpeed()//protected 자식은 접근 가능, 그 외에는 불가능 
    {
        return CalcSpeed();
    }

    private float CalcSpeed() // private는 자식 클래스에 사용 불가능 
    {

        return 100f / (weight * year);
    }

}

public class Dog: Animal
{
    public void Hunt()
    {
        float speed = GetSpeed();
        Debug.Log(speed + "의 속도로 달려가서 사냥");

        weight += 10f;
    }
}

public class Cat : Animal 
{
    public void Stealth()
    {
        Debug.Log("숨기");

    }

}