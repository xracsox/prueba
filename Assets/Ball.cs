using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 mov;
    public float speed;
   public bool jump;
    public bool doubleJump;
    public float jumpPower;
   public bool grounded;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (grounded)
            {
                jump = true;
                doubleJump = true;
            }
           


            else if (doubleJump)
            {
                jump = true;
                doubleJump = false;
            }
        }
        
        
           

       
        
    }
    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal")* speed,0, Input.GetAxis("Vertical")* speed);
        

            if (jump)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0,rb.velocity.z);
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                jump = false;
            }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            grounded = true;
           
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
          
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
            doubleJump = true;
       
        }
    }
}
