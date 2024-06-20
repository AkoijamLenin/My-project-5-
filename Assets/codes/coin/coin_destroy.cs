using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_destroy : MonoBehaviour
{
    public Rigidbody2D rd;

    public float timer=10f;
    private float timecount = 0f;

   
    void Update()
    {
        
       timecount += Time.deltaTime;
        if(timecount>=timer)
        {
            Destroy(gameObject);
        }
    }
}
