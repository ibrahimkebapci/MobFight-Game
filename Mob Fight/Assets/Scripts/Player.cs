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
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        _joyistick = FindObjectOfType<FixedJoystick>();   
    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joyistick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joyistick.Vertical * _moveSpeed);
    }
    

}
