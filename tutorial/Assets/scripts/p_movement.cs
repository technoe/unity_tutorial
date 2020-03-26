using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_movement : MonoBehaviour
{
  public Rigidbody rb;
  
  public float z = 1f;
  public float y = 1f;
  public float x = 1f;
  public float sleep = .2f;
  public float jforce = 5;
    // Update is called once per frame
    // Use FixedUpdate for physics based objects
  public bool w = false;
  public bool a = false;
  public bool s = false;
  public bool d = false;

  public bool sp = false;

  public bool jump = false;

  void Update()
  {
    w = Input.GetKey("w");
    a = Input.GetKey("a");
    s = Input.GetKey("s");
    d = Input.GetKey("d");
    sp = Input.GetKeyDown("space");

  }

  void FixedUpdate()
  {
    // AddForce(x, y, z);
    float dtime = Time.deltaTime;
    float z_time = z * dtime;
    float x_time = x * dtime;
    rb.AddForce(0, 0, z_time);

    // left
    if(a)
    {
      rb.AddForce(-x_time, 0, 0, ForceMode.VelocityChange);
    }

    // right
    if(d)
    {
      rb.AddForce(x_time, 0, 0, ForceMode.VelocityChange);
    }

    if(sp)
    {
      rb.AddForce(0, jforce, 0);
    }

    if ( rb.position.y < -1f )
    {
      FindObjectOfType<gameManager>().EndGame();
    }
  }
}
