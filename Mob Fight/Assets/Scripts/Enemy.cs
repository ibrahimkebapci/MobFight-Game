using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    private float dist;
    public float moveSpeed;
    public float howClose;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainPlayer")
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainPlayer").transform;
    }
    void Update()
    {

        if (gameObject== null)
        {
            return;
        }
        dist = Vector3.Distance(player.position, transform.position);

        if(dist <= howClose)
        {
            transform.LookAt(player);
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
        }
    }
}