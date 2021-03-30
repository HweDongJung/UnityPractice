using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float size = 30f;
        Debug.Log("원의 사이즈 " + GetRadius(size) );
    }

    float GetRadius(float size)
    {
        float pi = 3.14f;
        float tmp = size / pi;
        float radius = Mathf.Sqrt(tmp);

        return radius;
    }
}
