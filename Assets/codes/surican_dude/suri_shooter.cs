using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suri_shooter : MonoBehaviour
{
    public GameObject surican;

    private void Start()
    {
       // Shoot();
        Invoke("Shoot", 0.4f);
        //Invoke("ame", 3f);
    }
    private void Shoot()
    {
        Instantiate(surican, new Vector3(transform.position.x, transform.position.y, 0),transform.rotation);
    }
    private void Update()
    {
        //Instantiate(surican, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
    private void ame()
    {
        Debug.Log("uhuhuhuhuhu");
    }



}
