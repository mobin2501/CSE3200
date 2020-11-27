using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform cam;
    public Rigidbody2D rb;
    Vector3 pos = new Vector3(5f, 1.472f, -10f);
    private void FixedUpdate()
    {
        if (rb.transform.position.x > -5)
        {
            cam.transform.position = rb.transform.position + (pos);
        }
        
    }
}
