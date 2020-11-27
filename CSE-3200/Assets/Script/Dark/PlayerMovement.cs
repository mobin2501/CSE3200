using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator ani;
    Vector3 pos = new Vector3(.1f, 0f, 0f);

    bool jump = false;
    Vector2 force = new Vector2(0f,200f);

    bool jump2 = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }
        if (Input.GetKey(KeyCode.W) && jump == true && jump2==true)
        {
            Debug.Log("Working");
            rb.AddForce(force);
            //ani.SetBool("Jump_R", true);
            jump = false;
            
        }
        else
        {
            //ani.SetBool("Jump_R", false);
        }
    }
    private void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position = rb.transform.position + pos;
            ani.SetBool("Walk_R", true);
            ani.SetBool("Walk_L", false);
        }
        else
        {
            ani.SetBool("Walk_R", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position = rb.transform.position - pos;
            ani.SetBool("Walk_L", true);
            ani.SetBool("Walk_R", false);
        }
        else
        {
            ani.SetBool("Walk_L", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            
        }
        else
        {
            
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        jump2 = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump2 = true;
    }

}
