using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0); // global 위치 수정
        transform.localPosition = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
