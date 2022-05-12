using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "CloneBox")
        {
            Instantiate(gameObject);
        }
    }
}
