using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript2 : MonoBehaviour
{   
    public Transform tf;
    private Transform clonetf;
    public GameObject template;
    public Rigidbody rb;
    // Start is called before the first frame update

    private void Start()
    {
        
    }

    void Update()
    {   clonetf = template.GetComponent<Transform>();
            clonetf.position = tf.position;
        if (Input.GetKey(KeyCode.C))
        {
            Instantiate(template);
            Instantiate(template);
            Instantiate(template);
            Instantiate(template);
            clonetf.position =  new Vector3(tf.position.x , tf.position.y, tf.position.z + (float)0.2);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3((float)(tf.position.x + 0.2), tf.position.y, tf.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3((float)(tf.position.x - 0.2), tf.position.y, tf.position.z);
        }
   
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = new Vector3((tf.position.x), tf.position.y,(float) (tf.position.z + .2));
        }
        if (Input.GetKey(KeyCode.S))
        {
            tf.position = new Vector3((tf.position.x), tf.position.y, (float)(tf.position.z - .2));
        }
   
        
        
    }
}