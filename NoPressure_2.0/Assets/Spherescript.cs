using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherescript : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    public GameObject Clone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
             rb.AddForce(0, 0, (float)-6);
        }
        if (Input.GetKey(KeyCode.D))
        {
             rb.AddForce(0, 0, (float)6);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 200, 0);
            Instantiate(Clone);
        }
        
    }
}
