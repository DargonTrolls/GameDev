using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHeading : MonoBehaviour
{
    public Vector3 heading;

    private Vector3 currentposition;
    private Vector3 lastposition;
    
    public Vector3 modelheading;
    //public Vector3 invheading;
       
    void Start()
    {
        lastposition = transform.position;
    }

  
    void FixedUpdate()
    {
        currentposition = transform.position;
        heading = (currentposition - lastposition);
        lastposition = transform.position ;
        //invheading = 1 / heading;
        modelheading = transform.InverseTransformDirection(heading).normalized;
    }
}
