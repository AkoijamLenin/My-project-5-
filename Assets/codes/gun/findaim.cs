using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class findaim : MonoBehaviour
{
    //public GameObject a;
    //public GameObject b;
    public float time = 0f;
    public float tcount = 1.2f;
   

    // Update is called once per frame
    void Update()
    {
        time = time +Time.deltaTime;
        if (time >= tcount)
        {
            Destroy(gameObject);
            //Debug.Log("destroyed");
        }
    }
}
