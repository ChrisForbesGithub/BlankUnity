using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public = this can be seen by other scripts
    //int = a whole number
    public int age;
    //string = a collection of characters
    public string name;
    //float = decimal number
    public float height;

    public bool adult;

    public bool dead;

    public int ageOfDeath;

    // Start is called before the first frame update
    private void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
        {
            //run our GrowOlder code
            GrowOlder();
        }
    }

    public void GrowOlder()
    {
        //add one to your current age
        age += 1;
        //if the age is equal or greater than 18
        if (age >= 18)
        // then set adult to true
        {
            adult = true;
        }

        if (age >=ageOfDeath)
        {
            dead = true;
        }

    }

    public void Dead()
    { 
     
    }
}
