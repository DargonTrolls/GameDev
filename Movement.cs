using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float movespeed;
    private GetMousePositon getMousePosition;

    private CombatAnimationController combatAnimationController;

    private void Awake()
    {
        combatAnimationController = GetComponent<CombatAnimationController>();
        getMousePosition = GetComponent<GetMousePositon>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            Move();
            
        }
        transform.LookAt(transform.position + getMousePosition.mousePositon);
    }
    public void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * movespeed * Time.deltaTime;

        if (combatAnimationController.isrunning)//check if wanting to run
        {
            direction *= 3; //increase movespped to running
        }
        
        transform.position += direction;
    }
}
