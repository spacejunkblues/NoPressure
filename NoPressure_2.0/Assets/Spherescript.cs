using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherescript : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    public bool Onground = false;
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
        if(Input.GetKey(KeyCode.Space) || Onground)
        {
            rb.AddForce(0, 10, 0);
            Onground = false;
        }
        void OnCollisionStay(Collision col)
        {
            if (col.collider.name == "cube")
            {
                Onground = true;
            }
            
        }
    }
}
