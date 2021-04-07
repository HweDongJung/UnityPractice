using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : BaseMonster
{
    public override void Attack()
    {
        Debug.Log("광역 전함 공격력: " + damage);
    }
}
