//Marshal Fleck
//Unity/Clonescript2
//Out of range, and doubling Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript2 : MonoBehaviour
{
    
    public material[] playershade;
    bool bl;
    private Vector3 v3;
    int counter;
    public GameObject clone;
    public Rigidbody rb;
    public Transform tf;
    // Start is called before the first frame update
    void FixedUpdate()
    {

        counter += 1;
        if (tf.position.x >= 66) 
        {
            Destroy(clone);
        }
        if (tf.position.x <= 0)
        {
            Destroy(clone);
        }

        //out of range on the Z axis
        if (tf.position.z >= 80 || tf.position.z <= 30)
        {
            Destroy(clone);
        }
        rb.AddForce(0, 0, 0);
        
       
        
        if(Input.GetKey(KeyCode.O))
        {
          Instantiate(clone);
           
        }
        if(counter == 700)
        {
          Destroy(clone);
        }
        if(counter == 700)
        {
          Destroy(clone);
        }
        if(counter == 700)
        {
          Destroy(clone);
        }
        if(counter == 700)
        {
          Destroy(clone);
        }
        if(Input.GetKey(KeyCode.H))
        {
          Destroy(clone);
          
        }
        if(Input.GetKey(KeyCode.P))
        {
          bl = true;
        }
        if(bl == true)
        {
           tf.position = new Vector3(v3.x + tf.position.x, v3.y + tf.position.y, v3.z + tf.position.z );
           bl = false;
        } 
        
    
    }
     void Start()
     {
         v3 =  Random.insideUnitCircle * 1;
     }
    
}
