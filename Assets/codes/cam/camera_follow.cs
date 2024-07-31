using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform cam;
    public float caMPOS=1.4F;
    public float caMPOSz;



    
    void Update()
    {
        cam.transform.position = new Vector3(transform.position.x,transform.position.y+caMPOS,transform.position.z-caMPOSz);
    }
    //6 is the default
}
