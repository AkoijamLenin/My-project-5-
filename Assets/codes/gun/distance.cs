using UnityEngine;

public class distance : MonoBehaviour
{
    public Camera cam;
    public Vector3 direction;
    public Vector3 mospos;
    public float angle;
    public Transform gun;
    private bool isright=true;

    
    private void Update()
    {
        mospos = cam.ScreenToWorldPoint(Input.mousePosition);
        mospos.z = 0f;
        direction = (mospos - transform.position).normalized;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
         transform.rotation= Quaternion.Euler(0,0,angle);
        // transform.eulerAngles = new Vector3(0,0,angle);
        //Debug.Log(direction);
       if(mospos.x<transform.position.x)
        {
            //Debug.Log(mospos);
        }
       
        if(mospos.x<transform.position.x&&isright)
        {
            flip();
        }
        else if(mospos.x>transform.position.x&&!isright)
        {
            flip();
        }
    }
    private void flip()
    {
        isright= !isright;
        gun.localScale = new Vector3(gun.localScale.x, gun.localScale.y * -1, gun.localScale.z);
       // gun.transform.Rotate(0f, 180f, 0f);
       // Debug.Log("flip");
    }

}
