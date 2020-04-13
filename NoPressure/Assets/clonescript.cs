using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript : MonoBehaviour
{


    private int counter;
    public GameObject clone;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        counter = counter + 1;

        if(counter == 250)
        {

            Destroy(gameObject);

        }


        rb.AddForce(0, 0, -5);

        

    }
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.name == "player")
        {


            Destroy(gameObject);
            

        }
    }


}







