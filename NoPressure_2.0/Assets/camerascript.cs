using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public Transform tf;
    float Spees = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = new Vector3((float)tf.position.x, (float)tf.position.y, (float)tf.position.z + (float)Spees);
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3((float)tf.position.x - (float)Spees, (float)tf.position.y, (float)tf.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3((float)tf.position.x + (float)Spees, (float)tf.position.y, (float)tf.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            tf.position = new Vector3((float)tf.position.x, (float)tf.position.y, (float)tf.position.z - (float)Spees);
        }
    }
}
