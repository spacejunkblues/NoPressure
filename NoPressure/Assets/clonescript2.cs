using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript2 : MonoBehaviour
{
    //Declaring variables and references
    public Transform tf;
    public Rigidbody rb;
    public GameObject clone;
    public Material[] material;
    public int i;
    Renderer rend;
    int counter = 0;
    
    //Init variables
    

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
       Destroy((GameObject)clone);
       Destroy(this);
     }
     if(Input.GetKey(KeyCode.P))
     {
       rb.AddForce(14, 13, 0);
     } 

    }
    void Start()
    {
        rend = clone.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[i];
        
        tf.position =  new Vector3(tf.position.x, tf.position.y, tf.position.z + (float) 2.0);
        
    
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
    void FixedUpdate()
    {
      counter += 1;

      if(counter == 300)
      {
        Destroy(clone);
      }
      if(counter == 50)
      {
        nextcolor();
      } 


    }


}
