using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_manager : MonoBehaviour
{
    public GameObject menu;
    //SceneManager sceneManager;
    void OnEnable()
    {
        health_changer.jug2 += menugo;
    }
    void OnDisable()
    {
        health_changer.jug2 -= menugo;
    }
    public void menugo()
    {
        menu.SetActive(true);
    }
    public void Retry()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene(SceneManager.GetActiveScene());

    }
}
