using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using Unity.EditorCoroutines.Editor;

public class CloneScript : MonoBehaviour
{


    function Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(gameObject);
        }
    }

}
