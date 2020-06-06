using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;
    float Size = 0.3f;
    bool onground = true;

    // Start is called before the first frame update
    void Start()
    {
       tf.position = new Vector3((Random.Range(-10.0f, 10.0f)), tf.position.y, (Random.Range(-10.0f, 10.0f)));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = new Vector3((float)tf.position.x, (float)tf.position.y, (float)tf.position.z + (float)Size);
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3((float)tf.position.x - (float)Size, (float)tf.position.y, (float)tf.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3((float)tf.position.x + (float)Size, (float)tf.position.y, (float)tf.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            tf.position = new Vector3((float)tf.position.x, (float)tf.position.y, (float)tf.position.z - (float)Size);
        }

        if(Input.GetKeyDown(KeyCode.Space) && onground)
        {
            rb.AddForce(0, 300, 0);
            Instantiate(this);
            onground = false;
        }
    }

    private void OnCollisionStay(Collision collision)//the Collision varible that gets passed, has infomation about what the car collided with. 
    {
       // Debug.Log(collision.collider.name);
        Debug.Log(collision.gameObject.name);
        if(collision.collider.name == "floor")
        {
            onground = true;
        }
        onground = true;
        
    }
}
