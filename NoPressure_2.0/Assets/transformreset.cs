using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformreset : MonoBehaviour
{
    public Transform tf;
    private Transform playertf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playertf = GetComponent<Transform>();
        tf.position = playertf.position;
    }
}
