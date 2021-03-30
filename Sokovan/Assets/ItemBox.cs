using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;
    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger 되는 그 순간 한번 재생 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
 
    }

    //Trigger되고 다시 빠져나갔을때 
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }
}
