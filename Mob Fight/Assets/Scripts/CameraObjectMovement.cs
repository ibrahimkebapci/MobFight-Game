using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    // Update is called once per frame
        void Update()
        {
            GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
        }
    
}
