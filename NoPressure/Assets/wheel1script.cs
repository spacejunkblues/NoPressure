using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel1script : MonoBehaviour
{
    //Declaring references
    public Rigidbody rb;
    public Transform tf;
    public Vector3 v3;
    public GameObject player;
    private Transform tran;

    // Start is called before the first frame update
    void Start()
    {
        
   
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
       {
           rb.AddForce(0, 0, 4);
       }
       if (Input.GetKey(KeyCode.S))
       {
           rb.AddForce(0, 0, -4);
       }
       if (Input.GetKey(KeyCode.A))
       {
           
       }
       if (Input.GetKey(KeyCode.D))
       {
           rb.AddForce(4, 0, 0);
       }
    }
}
