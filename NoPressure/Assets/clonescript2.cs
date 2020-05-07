using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript2 : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    public GameObject clone;
    public Material[] material;
    public int i;
    Renderer rend;
    // Start is called before the first frame update
    void Update()
    {
     rend.sharedMaterial = material[i]; 
     if(Input.GetKey(KeyCode.O))
     {      
       Instantiate(clone);      
       nextcolor();
       
       
     }
     if (Input.GetKey(KeyCode.H))
     {
       Destroy(clone);
     }
     if(Input.GetKey(KeyCode.P))
     {
       rb.AddForce(14, 10, 0);
     } 

    }
    void Start()
    {
        rend = clone.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[i];
        
        tf.position =  new Vector3(tf.position.x , tf.position.y, tf.position.z + (float)0.2);
    
    
    }
    public void nextcolor()
    {
      
      if(i<2)
      {

       i++;
      }
      else
      {
        i += 1;
      }

    }
    
}
