using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal jack = new Animal();
        jack.name = "jack";
        jack.sound = "멍멍";
        jack.weight = 60;
        Animal cat = new Animal();
        cat.name = "캬루";
        cat.sound = "네놈들 게임은 망했어!";
        cat.weight = 45;
        Animal horse = new Animal();
        horse.name = "말딸";
        horse.sound = "히이잉";
        horse.weight = 128;

        jack = cat;

        Debug.Log("나는 "+ cat.name+ "다 " +cat.sound);
        Debug.Log("나는 원래 jack이었지만 " + jack.name + "가 되버렸어 그리고 " + jack.sound);
    }

}


public class Animal //Animal 클래스 생성, 이름, 소리, 몸무게의 요소 부여
{
    public string name;
    
    public string sound;

    public float weight;



}