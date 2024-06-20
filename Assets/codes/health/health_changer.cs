using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class health_changer : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public Gradient gradient;
    public static event Action jug2;
    void OnEnable()
    {
        player_health.jug += healthchange;
        //Debug.Log("hahaha");
    }
    void OnDisable()
    {
        // Debug.Log("yyyyyyyyy");
        player_health.jug -= healthchange;
    }

    private void Start()
    {
        fill.color = gradient.Evaluate(1f);
    }
    /*public void healthchange(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
   */
    public void healthchange()
    {
        slider.value -=1;
        fill.color = gradient.Evaluate(slider.normalizedValue);

        if(slider.value <= 0 )
        {
            jug2?.Invoke();
        }
    }
}
