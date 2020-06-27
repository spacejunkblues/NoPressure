using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulecontroller : MonoBehaviour
{
    bool onground;
    public Rigidbody rb;
    public Transform tf;
    public float Speed;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        onground = true;
        Speed = 0.05f;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter += 1;
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = new Vector3(tf.position.x, tf.position.y, tf.position.z + Speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3(tf.position.x - Speed, tf.position.y, tf.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            tf.position = new Vector3(tf.position.x, tf.position.y, tf.position.z - Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3(tf.position.x + Speed, tf.position.y, tf.position.z);
        }

        if (Input.GetKey(KeyCode.Space) && onground && counter > 3)
        {
            rb.AddForce(0, 130, 0);
            onground = false;
            counter = 0;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        onground = true;
    }
}
