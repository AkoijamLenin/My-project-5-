using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody2D rd;
    public Transform gdcheck;
    public float radius=0.9f;
    public LayerMask lm;
    public TrailRenderer Tr;

    public float horizontal=0;
    public float movespeed=25f;
    public float jumpspeed = 30f;
    public float fallgrav = 5f;
    public bool isgrounded;
    private bool isright = true;
    public bool candash=true;
    public bool isdashing=false;
    public float dashtime=1f;
    public float dashcooldown=1f;
    public float dashpower = 17f;

    public float jumpcheck=0;
    public bool canjump;
    public float cayote = 0.2f;
    private float cayotecounter;
    public float jumpbuffer = 1f;
    private float jumpbuffercounter;
    private float dashdirection;
    void Update()
    {
         //Debug.Log("y="+rd.velocity.y);
         //Debug.Log("x="+rd.velocity.x);


        if (isright == true) { dashdirection = 1f; }
        else if(isright == false) {  dashdirection = -1f; }
        if(isdashing==true)
        { return; }
        horizontal = Input.GetAxis("Horizontal");
        //if(Input.GetKeyDown(KeyCode.Space)&&isgrounded==true)
        if (Input.GetButtonDown("Jump") )
        //if (Input.GetButtonDown("Jump") && isgrounded==true)
        {
            //if (isgrounded==true || canjump==true)
            if (cayotecounter>=0 || canjump == true)
            {

            rd.velocity = new Vector2(rd.velocity.x,jumpspeed);
                jumpcheck += 1;
                if (jumpcheck <= 1) { canjump = true; }
                else { canjump = false; }
                
            }
           // rd.AddForce(new Vector2(transform.localScale.x*1000f,jumpspeed),ForceMode2D.Impulse);
           // rd.velocity=new Vector2( 90f, jumpspeed);
            
        }
        if (rd.velocity.y > 0)
        {
            rd.gravityScale = 10f;
        }
        if(isgrounded)
        {
            canjump = true;
            cayotecounter = cayote;
        }
        if(isgrounded==false)
        {
            cayotecounter-=Time.deltaTime;
        }
       
      

        if (Input.GetKeyDown(KeyCode.LeftShift)&&candash==true)
        {
            StartCoroutine(dash());
        }

        isgrounded = Physics2D.OverlapCircle(gdcheck.position,radius,lm);
        

    }
    private void FixedUpdate()
    {
        /*
        if (isgrounded == false )                                                               //I added this piece of code and my problem is gone 
        {                                                                                       //I am so happy finally i solved my problem
            if (horizontal==0)                                                                  //It took me a week to solve the problem
           {                                                                                    //the problem was that the character jumps a bit heigher if we release the jump
                // rd.AddForce(new Vector2(rd.velocity.x,-10f),ForceMode2D.Impulse);            //button early
                rd.velocity=new Vector2(rd.velocity.x, -10f);                                 //I am so happy
                  //rd.velocity=new Vector2(transform.localScale.x*64f,-10f);
                //rd.AddForce(new Vector2.right);                                               //I fixed it
            }                                                                                   
        }      */                                                                                 // With just 8 lines of code
        if (isdashing == true)
        { return; }
         rd.velocity = new Vector2(horizontal * movespeed, rd.velocity.y);
        
        if (horizontal>0&&isright==false )
        {
            flip();
           
        }
            
        if (horizontal < 0 && isright == true)
        {
            flip();
           
        }
       if(rd.velocity.y<0) { rd.gravityScale =fallgrav; }
       if(isgrounded) { 
            
        rd.gravityScale=2.5f;
        }


    }

    private void flip()
    {
       // Vector3 temp=gameObject.transform.localScale;
       // temp.x *= -1f;
       // gameObject.transform.localScale = temp;
       transform.Rotate(0,180,0);
        isright = !isright;
    }
    private IEnumerator dash()
    {
        candash = false;
        isdashing = true;
        float temp2= rd.gravityScale;
        rd.gravityScale = 0f;

        //rd.velocity=new Vector2(transform.localScale.x*dashpower,0f);(original one)

        rd.velocity = new Vector2(dashdirection * dashpower, 0f);
        //rd.velocity = Vector2.right * transform.localScale.x * dashpower;
        Tr.emitting = true;
        yield return new WaitForSeconds(dashtime);
        Tr.emitting=false;
        rd.gravityScale = temp2;
        isdashing=false;
        yield return new WaitForSeconds(dashcooldown);
        candash = true;


    }
   
}
