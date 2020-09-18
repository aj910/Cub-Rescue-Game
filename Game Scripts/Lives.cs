 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class Lives : MonoBehaviour
 
 public float speed; 
 
 public Text countText;
 public Text livesText;
 public Text winText;
 public Text winText2;
 public Text winText3;
 public Text loseText;
 private Rigidbody2D rb2d;      
 private int count;
 private int lives;
 
 void Start()
 {
     rb2d = GetComponent<Rigidbody2D>();
     count = 0;
     lives = 3;
     winText.text = "";
     winText2.text = "";
     winText3.text = "";
     loseText.text = "";
     SetLivesText();
 
     SetCountText();
 }
 void FixedUpdate()
 {
     float moveHorizontal = Input.GetAxis("Horizontal");
     float moveVertical = Input.GetAxis("Vertical");
     Vector2 movement = new Vector2(moveHorizontal, moveVertical);
     rb2d.AddForce(movement * speed);
     if (lives == 0)
     {
         SetLivesText();
     }
     if (Input.GetKey("escape"))
     {
         Application.Quit();
     }
        
 }
 void OnTriggerEnter2D(Collider2D other)
 {
     if (other.gameObject.CompareTag("Pentagon"))
     {
         other.gameObject.SetActive(false);
         count = count + 1;
         SetCountText();
     }
     if(other.gameObject.CompareTag("Enemy"))
     {
         lives--;
         SetLivesText();
     }
        
 }
 void SetLivesText()
 {
     livesText.text = "Lives: " + count.ToString();
    
     if (lives == 0)
     {
         loseText.text = "You have lost the game! Better luck next time!";
     }
 }
 void SetCountText()
 {
     countText.text = "Count: " + count.ToString();
     
     if (count >= 8)
     {
         winText.text = "Congragulations! You Win!";
         winText2.text = "Game created by Coding Ninjas ";
         winText3.text = "Challenge 1: Save the tiger";
     }
    
 }
       
}