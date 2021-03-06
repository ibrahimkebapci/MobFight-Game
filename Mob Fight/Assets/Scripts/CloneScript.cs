using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject PlayerClone;
    public Transform barrelEnd;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainPlayer")
        {
            GameObject newClone = Instantiate(PlayerClone, barrelEnd.position, barrelEnd.rotation);
            Destroy(gameObject);
        }
    }
}
