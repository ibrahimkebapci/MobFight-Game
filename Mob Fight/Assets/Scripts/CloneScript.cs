using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject PlayerClone;
    public Transform barrelEnd;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "BoxPlayer" || collider.gameObject.tag == "MainBoxPlayer")
        {
            GameObject newClone = Instantiate(PlayerClone, barrelEnd.position, barrelEnd.rotation);
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        
    }
    void Start()
    {
          //GameObject yeniNesne = Instantiate(PlayerClone, new Vector3(2, 3, 1), Quaternion.identity);
    }
    void Update()
    {
        

    }
}
