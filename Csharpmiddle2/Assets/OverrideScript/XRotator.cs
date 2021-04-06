using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class XRotator : BaseRotator
{
    protected override void Rotate()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);


    }
}
