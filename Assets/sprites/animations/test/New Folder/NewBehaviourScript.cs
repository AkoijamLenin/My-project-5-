using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public Animator animator_test;
    // Start is called before the first frame update
    void Start()
    {
        animator_test = GetComponent < Animator >();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            animator_test.SetBool("New Bool", true);
        }
    }
}
