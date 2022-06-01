using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    Vector3 imlecDunya;
    //public float speed = 1f;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        //GetComponent<Rigidbody>().velocity = Vector3.forward * 5;
        if(Input.GetMouseButtonDown(0))
        {
            imlecDunya = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20)); 
        }
        transform.position = Vector3.MoveTowards(transform.position,imlecDunya,.2f);
    }

}
