using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter(Collision collision)
     {
                 //here we check for the collider involved in the collision, and check its tag  
                 //if it matches enemy, proceed with the logic
 
         if(collision.gameObject.tag == "Enemy")
         {
                        //here you would proceed with the death sequence, since i dont know what it is, i made a template with a debug statement
             SceneManager.LoadScene ("GameOver");
         }

         if(collision.gameObject.tag == "Goal1")
         {
             SceneManager.LoadScene ("Clear1");
         }

         if(collision.gameObject.tag == "Goal2")
         {
             SceneManager.LoadScene ("Clear2");
         }

         if(collision.gameObject.tag == "Finish")
         {
             SceneManager.LoadScene ("Win");
         }
     }

}