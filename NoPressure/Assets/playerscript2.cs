using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript2 : MonoBehaviour
{   
    
    
    private Vector3 v3;
    public Transform tf;
    private Rigidbody clonerb;
    private Transform clonetf;
    public GameObject template;
    public Rigidbody rb;
    private Material[] mat;
    Renderer rend;
    int o = 0;

    // Start is called before the first frame update

    private void Start()
    {
       
        rend = template.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = mat[o];
    }

    void Update()
    {  
            clonerb = template.GetComponent<Rigidbody>();
            clonetf = template.GetComponent<Transform>();
            clonetf.position = tf.position;
        
        if (Input.GetKey(KeyCode.C))
        {
            
            
            Instantiate(template);
            Instantiate(template);
            clonetf.position =  new Vector3(tf.position.x , tf.position.y, tf.position.z + (float)12.0);
            clonetf.position = new Vector3(tf.position.x , tf.position.y, tf.position.z + (float)48.0);
            clonerb.AddForce(0, 0, 4);
            nextcolor();
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
     public void nextcolor()
    {
      
      if(o<2)
      {

       o += 1;
      }
      else
      {
        o += 1;
      }

    }
    
}