using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseMonster
{
    public override void Attack()
    {
        Debug.Log("한 캐릭터를 공격! 공격력 : " + damage);
    }
}
