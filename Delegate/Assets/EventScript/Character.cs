using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public delegate void Boost(Character target);
    public Boost playerBoost;

    public Booster booster;

    public string playerName = "회동";

    public float hp = 100;

    public float defense = 50;
    public float damage = 30;

    private void Start()
    {
        playerBoost(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBoost(this);
        }
    }
}
