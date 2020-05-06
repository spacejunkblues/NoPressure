//
//
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript2 : MonoBehaviour
{
    public GameObject clone;
    public Rigidbody rb;
    public Transform tf;
    // Start is called before the first frame update
    void Update()
    {

        if (tf.position.x >= 66) 
        {
            Destroy(clone);
        }
        if (tf.position.x <= 0)
        {
            Destroy(clone);
        }

        //out of range on the Z axis
        if (tf.position.z >= 90 || tf.position.z <= 30)
        {
            Destroy(clone);
        }
    }

    
}
