using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    public float hiz = 6f;
    Rigidbody rg;

    private void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector3 kuvvet = new Vector3(joystick.Horizontal*hiz, 0f, joystick.Vertical*hiz);
        rg.AddForce(kuvvet);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
