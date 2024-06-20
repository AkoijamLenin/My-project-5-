using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_force : MonoBehaviour
{
    public Rigidbody2D rd;
    public GameObject gameobject;
    public distance d;
    public Vector3 shoot_direction;
    

    private void Start()
    {
        gameobject=GameObject.FindWithTag("aim").GetComponent<GameObject>(); //these two are created for prefab
        d = GameObject.FindWithTag("aim").GetComponent<distance>();          //

        // rd= GetComponent<Rigidbody2D>();         //these two r original for ori object
        // d = gameobject.GetComponent<distance>(); //these are original


        shoot_direction = d.direction;    //here the direction is normalized
       // rd.velocity = new Vector2(shoot_direction.x, shoot_direction.y);
        //shoot_direction=(d.mospos-transform.position).normalized;     // here the source is gun point


       // shoot_direction = d.mospos - gameobject.transform.position;    // un normalized distance
        //rd.velocity = new Vector2(shoot_direction.x, shoot_direction.y) * 200f;
        //shoot_direction = d.mospos - gameObject.transform.position;    // un normalized distance of gameObject
        //transform.position = new Vector3(transform.position.x + shoot_direction.x, transform.position.y + shoot_direction.y, 0);
        // Debug.Log("bullet position="+transform.position);
        //Debug.Log("mouse position=" + d.mospos);

        // Debug.Log("aim position=" + gameobject.transform.position);

    }

    private void Update()
    {
        

        // shoot_direction = d.direction;
       // shoot_direction = d.mospos - gameobject.transform.position;   

    }
    void FixedUpdate()
    {
        // rd.velocity = new Vector2(shoot_direction.x, shoot_direction.y)*400f;
        //rd.velocity = new Vector2(shoot_direction.x, shoot_direction.y) * 200f;
        rd.velocity = new Vector2(shoot_direction.x, shoot_direction.y) * 150f;





        // transform.position = new Vector3(transform.position.x+shoot_direction.x,transform.position.y+shoot_direction.y,0);
        // rd.velocity = new Vector2(transform.localScale.x, transform.localScale.y) * 10f;

        // rd.AddForce(new Vector2(transform.position.x+2f, transform.position.y+2f), ForceMode2D.Impulse);

       
    }
}
