using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> score = new List<int>();
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randomScore = Random.Range(0, 100);
            score.Add(randomScore);
        }

        if (Input.GetMouseButtonDown(1))
        {
            
        }
    }
}
