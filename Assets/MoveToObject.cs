using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject followObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = followObject.transform.position;
    }
}
