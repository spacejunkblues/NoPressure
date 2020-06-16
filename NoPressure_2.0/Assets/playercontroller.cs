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
    public GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        tf.position = new Vector3(Random.Range(-10.0f, 10.0f), tf.position.y, Random.Range(-10.0f, 10.0f));
        onground = false;
        tf.localScale = new Vector3(tf.localScale.x + 100, tf.localScale.y + 100, tf.localScale.z + 100);
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
        //if (Input.GetKey(KeyCode.P))
        //{
        //   tf.localScale = new Vector3(tf.localScale.x + 1, tf.localScale.y +1,tf.localScale.z +1);
        //}
    }

    private void OnCollisionStay(Collision collision)//the Collision variable that gets passed, has infomation about what the car collided with. 
    {
        // Debug.Log(collision.collider.name);
        //Debug.Log(collision.gameObject.name);
        if(collision.collider.name == "floor")
        {
            onground = true;
        }

        if (collision.gameObject.name == "food(Clone)")
        {
            tf.localScale = new Vector3(tf.localScale.x + 1, tf.localScale.y + 1, tf.localScale.z + 1);
            Spees -= (float)0.005;
            Destroy(collision.gameObject);
        }
        
    }
}
