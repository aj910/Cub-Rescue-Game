using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile2 : MonoBehaviour
{
    public float min=2f;
    public float max=7.8f;
    public float moveSpeed=0.2f;
    // Use this for initialization
    void Start () {
       
        min=transform.position.x;
        max=transform.position.x+5.8f;
   
    }
   
    // Update is called once per frame
    void Update () {
       
       
        transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
       
    }
}
