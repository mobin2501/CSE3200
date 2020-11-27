using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator ani;

    Vector2 force = new Vector2(600f, 0f);
    Vector2 force2 = new Vector2(0, 150f);
    bool jump = false;
    bool jump2 = false;
    float st = 0f;
    float d = 0f;
    private void Update()
    { 
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Invoke("Right", 0f);
            ani.SetFloat("Speed", 1f);
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            Debug.Log("D");
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            ani.SetFloat("Speed", 0f);
            Debug.Log("Dup");
        }

        /* if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
         { 
             Invoke("Left", 0f);
         }*/

        if (Input.GetKeyDown(KeyCode.W))
        { 
            jump = true;
            //jump2 = true;
            
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            d = Time.time;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log(d);
            if (jump==true && jump2==true )
            {
                Invoke("Up", 0);
                jump = false;
            }
            
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Invoke("Down", 0);
        }
    }
    void Right()
    {
        rb.AddForce(force*Time.deltaTime,ForceMode2D.Force);
        Debug.Log("D");
    }
    void Left()
    {
        rb.AddForce(-force*Time.deltaTime,ForceMode2D.Force);
        Debug.Log("A");
    }
    void Up()
    {
        //Debug.Log("Up");
        rb.AddForce(force2*Time.deltaTime,ForceMode2D.Impulse);
    }
    void Down()
    {
        rb.AddForce(-force2*Time.deltaTime,ForceMode2D.Impulse);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        jump2 = false;
        st = Time.time;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump2 = true;
        Debug.Log(Time.time - st);
    }
}
