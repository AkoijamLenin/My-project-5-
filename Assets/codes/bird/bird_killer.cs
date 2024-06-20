using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bird_killer : MonoBehaviour
{
    public GameObject bird;
    public GameObject enemy;
    public float time = 0.2f;
    private void Start()
    {
        bird=GameObject.FindWithTag("bird").GetComponent<GameObject>();
        enemy=GameObject.FindWithTag("enemy").GetComponent<GameObject>();
    }
    // Update is called once per frame
   
      public void  OnCollisionEnter2D(Collision2D other)

        {
         if(other.gameObject.tag=="bird"|| other.gameObject.tag == "enemy")
         {
             Destroy(other.gameObject);
            //StartCoroutine(kill(other.gameObject));
            
            Destroy(gameObject);
           // Debug.Log("destroy enemy");
            
         }
        if (other.gameObject.tag == "spwall")
        {
           
            Destroy(gameObject);
            //Debug.Log("destroy");
        }
       }
    /*public IEnumerator kill(GameObject o)
    {
      //  Debug.Log("killed");
        // yield return new WaitForSeconds(time);
         yield return new WaitForSeconds(0.001f);
      //  Debug.Log("done");
        Destroy( o);
    }*/

}
