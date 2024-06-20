using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using Unity.VisualScripting;

public class bird_flip : MonoBehaviour
{
    public AIPath path;
    public GameObject bullet;
    public Animator  ani;
    private void Start()
    {
       // bullet=GameObject.FindWithTag("bullet").GetComponent<GameObject>();
    }
    void Update()
    {
        if (path.desiredVelocity.x <= 0.001f)
        {
            transform.localScale = new Vector3(-10f, 10f, 0f);
            //Debug.Log("left");
        }
        else if (path.desiredVelocity.x >= 0.001f) 
        {
          
            transform.localScale = new Vector3(10f,10f,0f);
           // Debug.Log("right");
        }
        //Debug.Log("speed="+ path.desiredVelocity.x);
       
     

       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            ani.SetBool("death", true);
           // Debug.Log("mission succes");
        }
    }
}
