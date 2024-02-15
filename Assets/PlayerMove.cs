using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //control how fast we move
    public float speed;
    public float jumpPower;
    public float sprintMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey("w"))
       {
            //if the player is pressing w
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * sprintMultiplier);
       }
       if (Input.GetKey("s"))
       {
            GetComponent<Rigidbody>().AddForce(Vector3.back * speed * sprintMultiplier);
       }
       if (Input.GetKey("a"))
       {
            GetComponent<Rigidbody>().AddForce(Vector3.left * speed * sprintMultiplier);
       }
       if (Input.GetKey("d"))
       {
            GetComponent<Rigidbody>().AddForce(Vector3.right * speed * sprintMultiplier);
       }
       if (Input.GetKeyDown("space"))
       {
           GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower);
       }
    }
}
