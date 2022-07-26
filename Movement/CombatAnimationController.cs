using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatAnimationController : MonoBehaviour
{
    Animator animator;
    GetHeading getHeading;

    public float forwardSpeed;
    public float sideSpeed;

    public bool ismoving;
    public bool isrunning;

    public float acceleration;
    public float deceleration;

   

    private void Awake()
    {
        animator = GetComponent<Animator>();
        getHeading = GetComponent<GetHeading>();
    }

    private void Update()
    {
        
        /*if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            ismoving = true;
            
        }
        else
        {
            ismoving = false;

        }

        //check for inputs and set running states
        if (Input.GetKey("left shift"))
        {
            isrunning = true;
        }
        else
        {
            isrunning = false;
        }*/

        animator.SetFloat("ForwardSpeed", forwardSpeed);
        animator.SetFloat("SideSpeed", sideSpeed);
    }
}
