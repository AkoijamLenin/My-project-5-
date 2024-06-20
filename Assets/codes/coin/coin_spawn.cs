using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_spawn : MonoBehaviour
{
    public Transform coin;
    public float widthoffset = 5f;
    private float timer=0f;
    public float time = 2f;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=time)
        {
            Instantiate();
            timer= 0f;
        }
        
    }
    void Instantiate()
    {
        float rightpoint=transform.position.x+widthoffset;
        float leftpoint=transform.position.x-widthoffset;
        Instantiate(coin,new Vector3(Random.Range(leftpoint,rightpoint),transform.position.y,0),transform.rotation);
        //Instantiate(coin);
    }
}
