using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class surican_collider : MonoBehaviour
{
    //public float [] t = { 1, 3, 5, 6, 53, 2 };
    public float [] t = { 53,53,53,53 };

    private void Start()
    {
        foreach(float i in t)
        {
           
             Debug.Log(i);
        }
    }
}
