using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
     void Update()
    {
       GetComponent<Rigidbody>().velocity = Vector3.forward * 2;
    }
    private void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
