using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
     public Transform player;
     public Vector3 Zpos;
  
     private void FixedUpdate() 
     {
      transform.position = player.position+Zpos;
     }
}