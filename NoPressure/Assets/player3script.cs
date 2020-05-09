using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3script : MonoBehaviour
{
    //Declaring references
    public Rigidbody rb;
    public Transform tf;
    public GameObject bullet;
    private Transform bullettf; 
    private Rigidbody bulletrb;

    // Start is called before the first frame update
    void Start()
    {
    bulletrb = bullet.GetComponent<Rigidbody>();
    bullettf = bullet.GetComponent<Transform>();
    bullettf.position = new Vector3 (tf.position.x, tf.position.y, tf.position.z); 

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.A))
       {
           rb.AddForce(-30, 0, 0);
       } 
       if (Input.GetKey(KeyCode.D))
       {
           rb.AddForce(30, 0, 0);
       } 
       if (Input.GetKey(KeyCode.W))
       {
           rb.AddForce(0, 30, 0);
       } 
       if (Input.GetKeyDown(KeyCode.Space))
       {
           Instantiate(bullet);
           bullettf.position = new Vector3 (tf.position.x, tf.position.y, tf.position.z);  
       }
       
    }
}
