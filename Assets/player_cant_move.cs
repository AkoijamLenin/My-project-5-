using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_cant_move : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(true);
    }
    void OnEnable()
    {
        health_changer.jug2 += player_death;    
    }
    void OnDisable()
    {
        health_changer.jug2 -= player_death;
    }
    void player_death()
    {
        gameObject.SetActive(false);
    }
}
