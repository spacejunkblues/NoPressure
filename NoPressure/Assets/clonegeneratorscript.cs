using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonegeneratorscript : MonoBehaviour
{


    private Vector2 v2;
    private Transform clonetf;
    public Transform tf;
    private int counter;
    public GameObject template;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;


    }

    void FixedUpdate()
    {

        counter = counter + 1;



        if(counter == 100)
        {

            counter = 0;
            Instantiate(template);
            clonetf = template.GetComponent<Transform>();
            clonetf.position = tf.position;
            v2 =  Random.insideUnitCircle * 3;
            clonetf.position = new Vector3 (v2.x, 0, 0) + tf.position ;


        }

    }



}
