using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtHeading : MonoBehaviour
{
    public GetHeading getHeading;

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(transform.position + getHeading.heading);
    }
}
