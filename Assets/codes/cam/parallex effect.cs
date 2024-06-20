using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallexeffect : MonoBehaviour
{
    public GameObject cam;
    public float startpos;
    public float distance;
    //public float distanceup;

    public float parallex;
    void Start()
    {
        cam=GameObject.Find("Virtual Camera");
        startpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        distance = (cam.transform.position.x)*parallex;
        //distanceup = (cam.transform.position.x)*parallex;

        transform.position = new Vector3 (startpos+distance,transform.position.y, transform.position.z);

    }
}
