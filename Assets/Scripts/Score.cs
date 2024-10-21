using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public End end;
    public static Score instance;
    public TextMeshProUGUI text;

    public int Points
    {
        get { return points; }
        set
        {
            points = value;
            text.text = points.ToString("D4");
            
            if(points % 50 == 0) Physics2D.gravity *= 1.1f;
            if(points <= -1) end.EndScene();
        }
    }
    
    private int points = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
         
    }
    
}
