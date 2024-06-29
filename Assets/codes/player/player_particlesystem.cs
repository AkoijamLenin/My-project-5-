using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_particlesystem : MonoBehaviour
{
    public Rigidbody2D rd;
    public ParticleSystem run;
    public ParticleSystem jump;
    public ParticleSystem land;

    public bool ground;
    void runt()
    {
        run.Play();
    } 
    void junt()
    {
        jump.Play();
    }void lunt()
    {
        land.Play();
    }

    public void Update()
    {
        if(ground==true && rd.velocity.x!=0) {
       // runt();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ground"))
        {
            ground = true;
            lunt();

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            ground = false;
           
            junt();
        }
    }
}