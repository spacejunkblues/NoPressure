using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class carscript : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    double acceleration = 0.0;
    int i = 0;
    public float rotation = 0;
    int counter = 0;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(0 - (float)acceleration, 0, 0);
            rb.AddRelativeForce(0, 0,  (float)acceleration);
            acceleration += 0.2;
        }
        else if(acceleration > 0.3)
        {
            acceleration -= 0.3;
        }

        if(Input.GetKey(KeyCode.A))
        {
            tf.eulerAngles = new Vector3(0, tf.eulerAngles.y - 3, 0);
        }

        if (Input.GetKeyDown(KeyCode.T)) 
        {
            Instantiate(this);
        }
        
    }

    //This function runs whenever the car collides with somehting else
    private void OnCollisionEnter(Collision collision)//the Collision varible that gets passed, has infomation about what the car collided with. 
    {
       // Debug.Log(collision.collider.name);
        Debug.Log(collision.gameObject.name);
        rb.AddForce(0, 150, 0);
        if (counter > 30)
        {
            Instantiate(this);
            counter = 0;
        }
        
    }

    private void FixedUpdate()
    {
        counter++;

        if (Input.GetKey(KeyCode.H)) 
        {
            Destroy(Player);
        }
    }
}
