using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Transform tf;
    public AudioSource jumpAs;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-3, 0, 0);
        }

        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 20, 0);
            Debug.Log("w");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(this);
            Debug.Log("c");
        }*/

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3((float)(tf.position.x + 0.2), tf.position.y, tf.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3((float)(tf.position.x - 0.2), tf.position.y, tf.position.z);
        }

    }
    void OnCollisionEnter(Collision collisionInfo)
    {



        jumpAs.Play();

    }
}
