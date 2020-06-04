using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript : MonoBehaviour
{
    public Rigidbody rb;
    Random rnd = new Random();
    float random;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        random = rnd.Next(2, 10);
        rb.AddForce(random, random, random);
    }
}
