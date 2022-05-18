using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using Unity.EditorCoroutines.Editor;

public class CloneScript : MonoBehaviour
{
    [Range(0,300) ]public int arrowCount
    private bool isDecreas = false;
    
    private void OnValidate()
    {
        if(arrowCount>arrows.Count && !isDecreas)
        {
            CreateArrow();
        }
        else if (arrows.Count>arrowCount)
        {
            isDecrease = true;
            DestroyArrows();
        }
        else
        {
            Diz();
        }
    }
    void CreateArrow()
    {
        for(int i =arrows.Count ;i<arrowCount;i++)
        {
            GameObject g = Instantiate(arrowObject, parent);
            arrows.Add(g);
            g.transform.localPsition = Vector3.zero;
        }
        Diz();
    }
    IEnumerator DestroyObject(GameObject g)
    {
        yield return new WaitForEndOfFrame();
        DestroyImmediate(g);
    }
    void DestroyArrows()
    {
        for(int i = arrows.Count().Count-1;i>=max;i--)
        {
            GameObject g = arrows[arrows.Count() - 1];
            arrows.RemoveAt(arrows.Count - 1);
            EditorCoroutineUtility.StartCorountine(DestroyObject(g), this);
        }
    }
    void Diz()
    {
        floar angle = 1f;
        float arrowCount = arrows.Count;
        angle = 360 / arrowCount;
        for (int i =0;i<arrowCount;i++)
        {
            MoveObjects(arrows[i].transform,i*angle)
        }
    }
    void GetRay()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.< = camera.main.transform.position.z;
        GetRay ray = Camera.main.ScreenPointToRay(mousePos);

        RayCastHit hit;
        if(Physics.raycast(ray , out hit , 100 , layerMask))
        {
            Vector 3 mouse = hit.point;
            mousePos.x = Mathf.Clamp(mousePos.x, mixX, maxX);
            mesafe = mousePos.x;
            Diz();
        }
    }
}
