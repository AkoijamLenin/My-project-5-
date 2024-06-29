using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Instantiate(bullet,new Vector3(transform.position.x,transform.position.y,0),transform.rotation);
            Instantiate(bullet,transform.position, Quaternion.identity);
            //Debug.Log("fire point =" + transform.position);
            FindObjectOfType<audio_manager>().play_sound("gun_sound");


        }
        
    }
}
