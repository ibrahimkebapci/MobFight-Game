using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    //private Camera camera;
    //Vector3 imlecDunya;
    //public float speed = 1f;
    //Rigidbody rigid;
    //bool right;
    //bool left;
    //float speed = 5.0f;
    //float jump = 5.0f;
    public Joystick joystick;
    public float runSpeed;
    float horizontalMove = 0f;


    private void Start()
    {

        //rigid = GetComponent<Rigidbody>();
        //camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    void Update()
    {
        if(joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
        }
        else if ( joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }
        //kayd?rd?kça hareket etme kodlar?
        //transform.Translate(0,0,speed*Time.deltaTime);
        //Vector3 turn_right = new Vector3(3.53f,transform.position.y, transform.position.z);
        //Vector3 turn_left = new Vector3(-4.19f, transform.position.y, transform.position.z);

        //if (Input.touchCount > 0)
        //{
        //    Touch finger = Input.GetTouch(0);

        //    if(finger.deltaPosition.x > 50)
        //    {
        //        right = true;
        //        left = false;
        //    }
        //    if (finger.deltaPosition.x < -50.0f)
        //    {
        //        right = false;
        //        left = true;
        //    }
        //    if (finger.deltaPosition.y < 50.0f)
        //    {
        //        rigid.velocity = Vector3.zero;
        //        rigid.velocity = Vector3.up * jump;
        //    }
        //    if (right== true)
        //    {
        //        transform.position = Vector3.Lerp(transform.position,turn_right,5);
        //    }
        //    if (left == true)
        //    {
        //        transform.position = Vector3.Lerp(transform.position, turn_left, 5);
        //    }
        //}

        //if(Input.touchCount >0)
        //{
        //    Touch parmak = Input.GetTouch(0);
        //    RaycastHit dokunulanNesne;
        //    if(Physics.Raycast(camera.ScreenPointToRay(parmak.position),out dokunulanNesne))
        //    {
        //        //if(dokunulanNesne.collider.gameObject.name=="CloneBox")
        //        //{
        //        //    Destroy(dokunulanNesne.collider.gameObject);
        //        //}
        //    }
        //}

        //dümdüz hareket ettirme 
        //GetComponent<Rigidbody>().velocity = Vector3.forward * 5;
        
        //tiklanilan yere hareket ettirme
        //if(Input.GetMouseButtonDown(0))
        //{
        //    imlecDunya = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20)); 
        //}
        //transform.position = Vector3.MoveTowards(transform.position,imlecDunya,.30f);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
