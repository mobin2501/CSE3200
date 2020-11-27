using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public Rigidbody2D rb;
    bool press = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("down");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("up");
        }
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Pressing");
            if (press == true)
            {
                Debug.Log("Nice");
                press = false;
            }
        }
    }
}
