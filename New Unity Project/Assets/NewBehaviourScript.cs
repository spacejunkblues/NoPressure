using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Declaring variables
    public Rigidbody2D rb;
    public Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tf.Position = new vector2 (tf.Position, tf.Position + 5);
        }

    }
}
