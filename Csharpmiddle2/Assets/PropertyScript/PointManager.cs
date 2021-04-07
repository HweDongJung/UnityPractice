using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public int point
    {
        get 
        {
            return m_point;
        }
        set 
        {
            if (value < 0) m_point = 0;
            else if (value > 10000) m_point = 10000;
            else m_point = value;
        }
    }
    private int m_point=0;

    
}
