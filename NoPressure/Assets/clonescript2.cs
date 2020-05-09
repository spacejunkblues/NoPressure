//Marshal Fleck
//Unity/Clonescript2
//Out of range, and doubling Script
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
    int countercounterpart = 0;
    public GameObject player;
    private Rigidbody playerrb;
    private Transform playertf;
    int velocity = 0;

    // Start is called before the first frame update
    void Update()
    {
      playerrb = player.GetComponent<Rigidbody>();
      playertf = player.GetComponent<Transform>();
      if(Input.GetKey(KeyCode.T))
      {
        tf.position =  new Vector3(playertf.position.x , playertf.position.y, playertf.position.z);
      
      }

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
       rb.AddForce(14, 13, 0);
     } 

    }
    void Start()
    {
        tf.position = new Vector3(tf.position.x, tf.position.y, tf.position.z + (float) 1.0);
        rend = clone.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[i];
        rb.AddForce(0, 0, 50);
        tf.position =  new Vector3(tf.position.x, tf.position.y, tf.position.z + (float) 1.0);
        
    
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
          if(tf.position.y < 20)
          {
            rb.AddForce(0, 10 * velocity, 0);
            velocity += 1;
          } 
          if(tf.position.y > 40)
          {
            rb.AddForce(0, -10 * velocity, 0);
            velocity += 1; 
          }
          if(tf.position.x > 60)
          {
            rb.AddForce(-30 * velocity, 0, 0);
            velocity += 1;
          }
          if(tf.position.z < 20)
          {
            rb.AddForce(-30 * velocity, 0, 0);
            velocity += 1;
          }
      
      
          if(tf.position.x < 10)
          {
            rb.AddForce(30 * velocity, 0, 0);
            velocity += 1;
          }
      
      
      if (counter <= 5)
      {
          rb.AddForce(0, 0, 500);
      }
      
      
      counter += 1;

      if(counter == 1000)
      {
        Destroy(clone);
      }
      if(counter >= countercounterpart)
      {
        nextcolor();
        countercounterpart += 100;
      } 


    }

}
