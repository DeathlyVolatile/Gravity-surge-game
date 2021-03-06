using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    

    public float movementspeed;
    float horizontalMovement;
    public Rigidbody2D prb;
    
    public float Health = 3;
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    public GameObject player;

    public float normalSize;
    public float smallSize;

    public ConsoleFix cf;
   
    public bool small;
    public bool flipped;

    public Text Lives;

    public AudioSource JuMp;

    void Awake()
    {
        
    }

    private void Start()
    {
        Lives.text = Health.ToString();
        

    }


    private void Update()
    {

        Lives.text = Health.ToString();

        if (Health <= 0)
        {
            SceneManager.LoadScene(1);
        }

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
        JuMp.Play();
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
