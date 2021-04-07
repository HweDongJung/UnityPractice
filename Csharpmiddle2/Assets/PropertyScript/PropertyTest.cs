using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTest : MonoBehaviour
{
    public PointManager pointManager;
    public MonsterManager monsterManager;
    private void Start()
    {
        //    pointManager.point = 100;

        //    Debug.Log(pointManager.point);
        //    pointManager.point = 99999;

        //    Debug.Log(pointManager.point);

        Debug.Log(monsterManager.count);
    }
}
