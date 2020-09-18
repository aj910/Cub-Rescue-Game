using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevel3 : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    private Animator myAnimator;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;

    //[SerializeField]
    //private Transform[] groundPoints;

    //[SerializeField]
    //private float groundRadius;

    //[SerializeField]
    //private LayerMask whatIsGround;

    //private bool isGrounded;

    private bool jump;

    [SerializeField]
    private float jumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        // = IsGrounded();
        //HandleMovement(horizontal);
        Flip(horizontal);
        HandleMovement(horizontal);
        Jump();
        //ResetValues();
    }

    private void HandleMovement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed,myRigidbody.velocity.y);

        //if (isGrounded && jump)
        //{
        //    isGrounded = false;
            //myRigidbody.AddForce(new Vector2(0, jumpForce));
        //    myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        //}

        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    private void Jump()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce); 
        } 
    }

    //private void HandleInput()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        jump = true;
    //    }
    //}

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    //private void ResetValues()
    //{
    //    jump = false;
    //}
    
    //private bool IsGrounded()
    //{
    //    if (myRigidbody.velocity.y <= 0)
    //    {
    //        foreach (Transform point in groundPoints)
    //        {
    //            Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);
    //
    //            for(int i = 0; i < colliders.Length; i++)
    //            {
    //                if (colliders[i].gameObject != gameObject)
    //                {
    //                    return true;
    //                }
    //            }
    //        }
    //    }
    //    return false;
    //}

    void OnCollisionEnter(Collision collision)
     {
                 //here we check for the collider involved in the collision, and check its tag  
                 //if it matches enemy, proceed with the logic
 
         if(collision.gameObject.tag == "Enemy")
         {
                        //here you would proceed with the death sequence, since i dont know what it is, i made a template with a debug statement
             SceneManager.LoadScene ("GameOver");
         }

         if(collision.gameObject.tag == "Finish")
         {
             SceneManager.LoadScene ("Win");
         }
     }
}
