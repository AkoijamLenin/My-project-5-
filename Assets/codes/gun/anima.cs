using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class anima : MonoBehaviour
{
    public Animator ani;
   
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(transform.localScale.y<0)
            {
                ani.SetBool("shootleft",true);
            }
            else if (transform.localScale.y > 0)
            {
                ani.SetBool("shoot", true);

            }
        }
        else
        {
            ani.SetBool("shoot", false);
            ani.SetBool("shootleft", false);
        }

    }
}
