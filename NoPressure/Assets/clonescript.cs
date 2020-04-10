using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonescript : MonoBehaviour
{



    private Transform clonetf;
    public Transform tf;
    private int counter;
    public GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        counter = counter + 1;
        


        if(counter == 100)
        {

            counter = 0;
            Instantiate(clone);
            clonetf = clone.GetComponent<Transform>();
            clonetf.position = tf.position;

        }

    }



}
