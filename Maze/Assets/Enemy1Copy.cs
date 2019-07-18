using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Copy : MonoBehaviour
{
    public float speed = 2;
    void Start()
    {
        
    }

    Vector2 pointA = new Vector2(-18, 3);
     Vector2 pointB = new Vector2(-18, 0);
     void Update()
     {
         transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
     }
}
