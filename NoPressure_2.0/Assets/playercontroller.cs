using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;
    float Spees = 0.08f;
    bool onground = true;
    public GameObject player;
    public Scene sc;

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
            tf.position = new Vector3((float)tf.position.x, (float)tf.position.y, (float)tf.position.z + (float)Spees);
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3((float)tf.position.x - (float)Spees, (float)tf.position.y, (float)tf.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = new Vector3((float)tf.position.x + (float)Spees, (float)tf.position.y, (float)tf.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            tf.position = new Vector3((float)tf.position.x, (float)tf.position.y, (float)tf.position.z - (float)Spees);
        }

        if(Input.GetKeyDown(KeyCode.Space) && onground)
        {
            rb.AddForce(0, 300, 0);
            onground = false;
        }
    }

    private void OnCollisionStay(Collision collision)//the Collision varible that gets passed, has infomation about what the car collided with. 
    {
       // Debug.Log(collision.collider.name);
        //Debug.Log(collision.gameObject.name);
        if(collision.collider.name == "floor")
        {
            onground = true;
        }

        else if(collision.collider.name == "zombie") 
        {
            if (collision.gameObject.transform.localScale.x > tf.localScale.x) 
            {
                Destroy(player);
            }
            else 
            {
                Destroy(collision.gameObject);
            }
        }
        
    }
}
