using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_surican : MonoBehaviour
{
    //public Transform suricandude;
    public float time=0f;
    public Rigidbody2D rd;
    public float speed=4f;
    public float Loca;
    private void Start()
    {
        rd= GetComponent<Rigidbody2D>();
       // Loca=suricandude.localScale.x;
    }

    void Update()
    {
        time += Time.deltaTime;

       rd.AddForce(new Vector2(speed*-1,rd.velocity.y),ForceMode2D.Impulse);
       //rd.AddForce(new Vector2(speed*Loca,rd.velocity.y),ForceMode2D.Impulse);

       // des();
    }
    private void des()
    {
        if(time>=3f)
        {
            Destroy(gameObject);
        }
    }
}
