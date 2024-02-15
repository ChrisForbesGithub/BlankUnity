using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float jumpPower;
    public float gravity;

    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Vector3.zero;

        //check if player should move forward or backward
        if (Input.GetKey("w"))
        {
            moveDirection.z += 1;
        }
        if (Input.GetKey("s"))
        {
            moveDirection.z -= 1;
        }

        //check if they should move left or right
        if (Input.GetKey("a"))
        {
            moveDirection.x -= 1;
        }
        if (Input.GetKey("d"))
        {
            moveDirection.x += 1;
        }

        moveDirection.x = moveDirection.x * speed;
        moveDirection.z = moveDirection.z * speed;
        moveDirection.y -= gravity * Time.deltaTime;

        if(controller.isGrounded)
        {
            

            if (Input.GetKeyDown("space"))
            {
                moveDirection.y = jumpPower;
            }
        }

        controller.Move(moveDirection * Time.deltaTime);
    }
}
