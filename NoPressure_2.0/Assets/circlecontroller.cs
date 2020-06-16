using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlecontroller : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tf.eulerAngles = new Vector3(tf.eulerAngles.x + 1, tf.eulerAngles.y, tf.eulerAngles.z);
            rb.AddRelativeForce(0, 0, 30);
        }
    }
}
