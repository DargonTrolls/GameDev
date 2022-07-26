using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePositon : MonoBehaviour
{
    public Vector3 mousePositon;
    [SerializeField] private Camera mainCamera;
    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            mousePositon = raycastHit.point;
        }

        
    }
}
