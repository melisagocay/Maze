﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;
    void Start()
    {
        
    }

    Vector2 pointA = new Vector2(-7, 4);
     Vector2 pointB = new Vector2(-5, 4);
     void Update()
     {
         transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
     }
}
