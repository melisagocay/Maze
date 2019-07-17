using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    
    public float speed = 0;
    void Start()
    {
        
    }

    Vector2 pointA = new Vector2(-10, -4);
     Vector2 pointB = new Vector2(-10, -1);
     void Update()
     {
         transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
     }
}
