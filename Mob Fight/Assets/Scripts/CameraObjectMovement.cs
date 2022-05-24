using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObjectMovement : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        float xDirection = Input.GetAxisRaw("Horizontal");
        float zDirection = Input.GetAxisRaw("Vertical");

        Vector3 moceDirection = new Vector3(xDirection, 0.0f, zDirection).normalized;

        transform.position += moceDirection * speed;
        
    }
}
