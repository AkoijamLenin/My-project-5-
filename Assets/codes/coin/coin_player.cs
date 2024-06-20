using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class coin_player : MonoBehaviour
{
    public logic_managers lm;
    
    
    private void Start()
    {
        lm = GameObject.FindWithTag("new").GetComponent<logic_managers>();
    }
    private void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            //Debug.Log("we hit the player");
            lm.addscore();

        }
    }
}
