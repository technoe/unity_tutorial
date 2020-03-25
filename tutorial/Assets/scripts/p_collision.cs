using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_collision : MonoBehaviour
{
    public p_movement movement;
    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "col_obstacle")
        {
            movement.enabled = false;
            Debug.Log("movement disabled");
        }        
    }
}
