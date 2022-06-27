using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent (typeof(Rigidbody), typeof (BoxCollider))]
public class Player : MonoBehaviour
{
    //public DynamicJoystick dynamicJoystick;
    public FixedJoystick fixedJoystick;
    public float speed;
    public float turnSpeed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joyistick;
    [SerializeField] private float _moveSpeed;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //dynamicJoystick = FindObjectOfType<DynamicJoystick>();
        fixedJoystick = FindObjectOfType<FixedJoystick>();

    }
    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            JoyistickMovement();
        }
        //_rigidbody.velocity = new Vector3(_joyistick.Horizontal * _moveSpeed,_rigidbody.velocity.y, _joyistick.Vertical * _moveSpeed);
        //transform.position = new Vector3(_joyistick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joyistick.Vertical * _moveSpeed);
    }

    public void JoyistickMovement()
    {
        float horizontal = fixedJoystick.Horizontal;
        float vertical = fixedJoystick.Vertical;  
        Vector3 addedPos = new Vector3(horizontal*speed*Time.deltaTime, 0 ,vertical*speed*Time.deltaTime);
        transform.position += addedPos;

        Vector3 direction = Vector3.forward * vertical +  Vector3.right * horizontal;
        transform.rotation = Quaternion.Slerp(transform.rotation , Quaternion.LookRotation(direction), turnSpeed*Time.deltaTime);
    }



}
