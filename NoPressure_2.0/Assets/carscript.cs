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
    public GameObject transformreset;
    private Transform tfreset;
        
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tfreset = GetComponent<Transform>();

        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, (float)4 + (float)acceleration);
            tf = tfreset;
            acceleration += 0.5;
        }
        else if(acceleration > 0.3)
        {
            acceleration -= 0.3;
        }

        if(Input.GetKey(KeyCode.A))
        {
            tf.eulerAngles = new Vector3(0, tf.eulerAngles.y - 3, 0);
        }
        

        
    }
}
