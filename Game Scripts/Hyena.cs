using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyena : MonoBehaviour
{
    
    //public float min=2f;
    //public float max=5f;
    //public float moveSpeed=0.1f;

    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;

    //void Start () {
       
        //min=transform.position.x;
        //max=transform.position.x+3f;
   
    //}
    
    // Update is called once per frame
    private void Update()
    {
        //transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);

        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        if (groundInfo.collider == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
        

}
