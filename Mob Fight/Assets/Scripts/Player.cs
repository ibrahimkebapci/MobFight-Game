using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public Camera camera;
    Vector3 imlecDunya;
    //public float speed = 1f;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
           Destroy(gameObject);
        }
    }
    private void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch parmak = Input.GetTouch(0);
            RaycastHit dokunulanNesne;
            if(Physics.Raycast(camera.ScreenPointToRay(parmak.position),out dokunulanNesne))
            {
                if(dokunulanNesne.collider.gameObject.name=="Player")
                {
                    
                }
            }
        }

        //dümdüz hareket ettirme 
        //GetComponent<Rigidbody>().velocity = Vector3.forward * 5;
        
        //t?klad???n yere hareket ettirme
        //if(Input.GetMouseButtonDown(0))
        //{
        //    imlecDunya = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20)); 
        //}
        //transform.position = Vector3.MoveTowards(transform.position,imlecDunya,.30f);
    }

}
