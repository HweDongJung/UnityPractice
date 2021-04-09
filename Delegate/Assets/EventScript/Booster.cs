using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(Character target)
    {
        Debug.Log(target.playerName + "의 체력 강화!");
        target.hp += 10;
    }

    public void ShieldBoost(Character target)
    {
        Debug.Log(target.playerName + "의 방어력 강화!");
        target.defense += 10;
    }

    public void DamageBoost(Character target)
    {
        Debug.Log(target.playerName + "의 공격력 강화!");
        target.damage += 10;
    }

    private void Awake()
    {
        Character player = FindObjectOfType<Character>();

        player.playerBoost += HealthBoost;
        player.playerBoost += ShieldBoost;
        player.playerBoost += DamageBoost;
    }
}
