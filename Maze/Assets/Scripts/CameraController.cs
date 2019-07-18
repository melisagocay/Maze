using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
      public static bool IsNull ( System.Object aObj )
   {// coherent check wether an object is null (is handled differently by unity), source: Bunny83 http://forum.unity3d.com/threads/148090-Fun-with-null
     return aObj == null || aObj.Equals ( null );
   }
 
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
