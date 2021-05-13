using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    public float movementspeed;
    float horizontalMovement;
    public Rigidbody2D prb;

    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    public GameObject player;

    public float normalSize;
    public float smallSize;

    public bool gotGrav = false;
    public bool gotSize = false;
    public bool small;
    public bool flipped;

    void Awake()
    {
       


    }

    
    private void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
      
      if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

      


        if (horizontalMovement > 0.01f && small == false )
        {

            transform.localScale = new Vector3(normalSize, normalSize, normalSize);
            
        }
      
        else if(horizontalMovement < -0.01f && small == false )
        {

            transform.localScale = new Vector3(-normalSize, normalSize, normalSize);
           


        }
       
        else if (horizontalMovement > 0.01f && small == true )
        {
            transform.localScale = new Vector3(smallSize, smallSize, smallSize);

        }
        else if (horizontalMovement < -0.01f && small == true )
        {
            transform.localScale = new Vector3(-smallSize, smallSize, smallSize);

        }

        
        
    }

     private void FixedUpdate()
    {
       

        Vector2 movement = new Vector2(horizontalMovement * movementspeed, prb.velocity.y);
        prb.velocity = movement;

      


    }

    void Jump()
    {
        Vector2 movement = new Vector2(prb.velocity.x, jumpForce);

        prb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }
}
