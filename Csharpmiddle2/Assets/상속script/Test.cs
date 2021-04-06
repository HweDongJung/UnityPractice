using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cat tom = new Cat();
        tom.name = "톰";
        tom.weight = 1.5f;
        tom.year = 3;

        Dog pike = new Dog();
        pike.name = "pike";
        pike.weight = 8f;
        pike.year = 5;

        tom.print();
        tom.Stealth();
        pike.Hunt();
        pike.print();

        Animal[] someAnimals = new Animal[2];
        someAnimals[0] = tom;
        someAnimals[1] = pike;
        tom.Stealth();

        for (int i = 0; i < someAnimals.Length; i++)
        {
            someAnimals[i].print();
        }

    }

  
}
