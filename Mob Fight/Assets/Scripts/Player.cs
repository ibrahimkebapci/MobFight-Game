using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent (typeof(Rigidbody), typeof (BoxCollider))]
public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joyistick;
    [SerializeField] private float _moveSpeed;
    //public Joystick joystick;
    //public float hiz = 5f ;
    //Rigidbody rg;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //rg = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3 (_joyistick.Horizontal * _moveSpeed , _rigidbody.velocity.y , _joyistick.Vertical* _moveSpeed);
    //    Vector3 kuvvet = new Vector3(joystick.Horizontal*hiz, 0f, joystick.Vertical*hiz);
    //    rg.AddForce(kuvvet);
    }

    
}
