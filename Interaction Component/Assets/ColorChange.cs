using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public void ChangeColor(int index)
    {
        Color color = new Color();

        switch (index)
        {
            case 0:
                color = Color.red;
                break;
            case 1:
                color = Color.green;
                break;
            case 2:
                color = Color.yellow;
                break;
            case 3:
                color = Color.gray;
                break;
            default:
                break;
        }

        GetComponent<Renderer>().material.color = color;
    }
}
