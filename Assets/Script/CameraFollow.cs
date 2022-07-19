using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform TargetFollow;
   
    void Update()
    {
  
        transform.position = new Vector3(TargetFollow.position.x, TargetFollow.position.y,transform.position.z);     
    }
}
