using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suri_spawn : MonoBehaviour
{
    float time = 0f;
    public float range = 7f;
    public float hori_range = 2f;
    public GameObject suri;
    public float up;
    public float down;
    public float right;
    public float left;
    private void Start()
    {
     up=transform.position.y+range;
     down=transform.position.y-range;

    right=transform.position.x+hori_range;
    left =transform.position.x - hori_range;
    }
    private void Update()
    {
        time+= Time.deltaTime;
        if(time>=2f)
        {
            
            Uins();
            time=0f;
        }
    }
    void Uins()
    {
        //Instantiate(suri,new Vector3(transform.position.x,Random.Range(up,down),0),transform.rotation);
        Instantiate(suri,new Vector3(Random.Range(left,right),Random.Range(up,down),0),transform.rotation);

    }
}
