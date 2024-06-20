using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class player_health : MonoBehaviour
{
    public static event Action jug;
  
    //public health_changer hp;
    //public int current_hp=4;
    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )  
        {
            current_hp -= 1;
            hp.healthchange(current_hp);
            //hp.slider.value=2f;
        }
    }
   */
    //private void OnCollisionEnter2D(Collision2D collision)
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if(collision.gameObject.tag=="bird")
        if (other.gameObject.tag == "bird")
        {

            Debug.Log("hahaha");
            jug?.Invoke();
        }
    }
}
