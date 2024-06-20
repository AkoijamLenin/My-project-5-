using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.Threading;

public class shake : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera;
    public float timer;
    public float totaltime;
    public float Intensity;
    
    private void Start()
    {
        VirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            camshake(5f, 0.1f);
            
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        //}
        // if (timer < 0)
        //{
            CinemachineBasicMultiChannelPerlin cbmc = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
            //cbmc.m_AmplitudeGain = 0f;
            cbmc.m_AmplitudeGain = Mathf.Lerp(Intensity, 0f,1-(timer/totaltime));
            //Debug.Log("time ends");
        }

    }
    public void camshake(float intensity,float time)
    {


         CinemachineBasicMultiChannelPerlin cbmc =VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cbmc.m_AmplitudeGain = intensity;
        timer=time;
        totaltime=time;
        Intensity= intensity;
        //Debug.Log("we can shake");
        
    }
   /* public void FixedUpdate()
    {
        if(timer>0)
        {
            timer-=Time.deltaTime;
        }
        if(timer<=0) {
            CinemachineBasicMultiChannelPerlin cbmc = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
            cbmc.m_AmplitudeGain = 0f;
        }
    }*/

}
