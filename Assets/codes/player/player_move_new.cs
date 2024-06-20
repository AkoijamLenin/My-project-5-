using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move_new : MonoBehaviour
{
   public  Rigidbody2D rd;
   public TrailRenderer tr;

    public float hori;
    public float movespeed=0;
    public float jumpspeed;
    private float maxspeed = 27f;
    public float acc = 0.1f;
    void Update()
    {
        hori = Input.GetAxis("Horizontal");//ohh wow today is my happiest day i finally fixed the problem.. i write GetAxis instead of GetAxisRaw....wow nice
        if(Input.GetKey(KeyCode.Space) )
        {
            //rd.velocity = new Vector2(1000f+movespeed, jumpspeed); 
            rd.velocity = new Vector2(0, jumpspeed);
        }
        
        
    }



    private void FixedUpdate()
    {
        movespeed += acc;
        if(movespeed > maxspeed ) { movespeed = maxspeed; }
        if (hori == 0) { movespeed = 0; }
        rd.velocity=new Vector2(hori*movespeed,rd.velocity.y);
    }
  

}
