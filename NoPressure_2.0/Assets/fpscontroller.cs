using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpscontroller : MonoBehaviour
{
    public Transform tf;
    public GameObject Bullet;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            tf.eulerAngles = new Vector3(tf.eulerAngles.x + 1, tf.eulerAngles.y, tf.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            tf.eulerAngles = new Vector3(tf.eulerAngles.x - 1, tf.eulerAngles.y, tf.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.eulerAngles = new Vector3(tf.eulerAngles.x, tf.eulerAngles.y - 1, tf.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.eulerAngles = new Vector3(tf.eulerAngles.x, tf.eulerAngles.y + 1, tf.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(0, 3, 0); 
        }
    }
}
