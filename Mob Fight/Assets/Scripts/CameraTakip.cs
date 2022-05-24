using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - Player.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
