using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform cam;
    public Transform player;
    static float x = 0f;
    Vector3 pos = new Vector3(x, 0f, -10f);
    private void Update()
    {
        x =  (player.transform.position.x);
        cam.transform.position = pos;
    }
}
