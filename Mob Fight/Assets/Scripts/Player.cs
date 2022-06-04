using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{  
    public Joystick joystick;
    public Joybutton joybutton;

    private void Start()
    {

        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

    }
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal*10f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical*10f
            ); 
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
