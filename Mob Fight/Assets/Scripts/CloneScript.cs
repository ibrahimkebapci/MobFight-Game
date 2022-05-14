using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject prefab;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            collider.transform.parent = this.transform;
            Instantiate(Player, new Vector2(0, -3.5f), Quaternion.identity);
        }
    }
}
