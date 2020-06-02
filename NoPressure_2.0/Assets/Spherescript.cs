using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherescript : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    public GameObject Clone;
    public int counter = 0;
    public int DoubleJump = 0;

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
        if(Input.GetKeyDown(KeyCode.Space) && DoubleJump < 3)
        {
            rb.AddForce(0, 200, 0);
            DoubleJump += 1;
        }
        if(counter > 300)
        {
            DoubleJump = 0;
            counter = 0;
        }  
        counter++;
    }
}
