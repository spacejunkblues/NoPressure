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
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(template);

        }
        
        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3((float)(tf.position.x + 0.2), tf.position.y, tf.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3((float)(tf.position.x - 0.2), tf.position.y, tf.position.z);
        }
   
   
   
   
    }
}