using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using System;



public class audio_manager : MonoBehaviour
{
    public sound[] t;
    public sound n;

    private void Awake()
    {
        foreach(sound i in t)
        {
            i.source=gameObject.AddComponent<AudioSource>();
            i.source.clip=i.clip;
            i.source.volume=i.volume;
            i.source.pitch=i.pitch;
            i.source.loop=i.loop;
            //  i.source.name=i.name;
           // i.source.mute = true;
            
        }

    }
     void Start()
    {
        play_sound("background_music");
    }


    public void play_sound ( string s_name)
    {
         n= Array.Find(t, o=>o.name==s_name);
        n.source.Play();
        //Debug.Log(n.name);  
        if(s_name== "background_go"|| s_name== "gameover")
        {

            foreach (sound i in t)
            {
                if(i.name=="background_music")
                {
                    Destroy(i.source);
                }
            }



        }

    }
  
}
