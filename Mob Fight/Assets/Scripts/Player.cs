using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public float speed;
    void Update()
    {
        float xDirection = Input.GetAxisRaw("Horizontal");
        float zDirection = Input.GetAxisRaw("Vertical");
        Vector3 moceDirection = new Vector3(xDirection, 0.0f,zDirection).normalized;

        transform.position += moceDirection*speed;
        
    }
}
