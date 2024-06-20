using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_spawn : MonoBehaviour
{
    public GameObject enemy;
    public float timer = 0f;
    public float tcount = 1.5f;

    void Update()
    {
        timer =timer+ Time.deltaTime;
        if(timer >= tcount)
        {
            
        Instantiate(enemy,new Vector3(transform.position.x,transform.position.y,transform.position.z),transform.rotation);
            timer = 0f;
        }

    }
}
