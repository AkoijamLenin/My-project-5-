using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_surican2 : MonoBehaviour
{
   // public Transform suricandude;
    public float time = 0f;
    public Rigidbody2D rd;
    public float speed;
    public float Loca;
    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
       // Loca = suricandude.localScale.x;
    }

    void Update()
    {
        time += Time.deltaTime;

          rd.AddForce(new Vector2(speed,rd.velocity.y),ForceMode2D.Impulse);
        //rd.AddForce(new Vector2(speed*Loca, rd.velocity.y), ForceMode2D.Impulse);

        // des();
    }
    private void des()
    {
        //if (time >= 0.5f)
        if(time > 3f)
        {
            Destroy(gameObject);
        }
    }
}
