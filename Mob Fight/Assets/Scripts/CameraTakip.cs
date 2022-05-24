using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public GameObject CameraObject;
    // Start is called before the first frame update
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - CameraObject.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = CameraObject.transform.position + offset;
    }
}
