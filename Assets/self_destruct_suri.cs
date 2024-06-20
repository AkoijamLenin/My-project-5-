using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self_destruct_suri : MonoBehaviour
{
    public float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1f)
        //if(timer > 3f)
        {
            Destroy(gameObject);
        }
    }
}
