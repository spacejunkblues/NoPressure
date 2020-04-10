using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{

    public AudioSource jumpAs;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 20, 0);
            Debug.Log("w");
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {



        jumpAs.Play();



    }
}
