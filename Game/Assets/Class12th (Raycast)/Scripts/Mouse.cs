using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit rayCastHit;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out rayCastHit,Mathf.Infinity))
            {
                Debug.Log(rayCastHit.collider.name);
            }
        }
        
    }
}
