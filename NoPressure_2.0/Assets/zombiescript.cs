using System.Collections;
using System.Collections.Generic;
//using System.Net.Http.Headers;
using UnityEngine;

public class zombiescript : MonoBehaviour
{

    public GameObject player;
    public Rigidbody rb;
    public bool ChangeOfDirection = false;
    public bool ToTheRight = false;
    public bool BehindYou;
    public int force = 1;

    // Start is called before the first frame update
    void Start()
    {
        ChangeOfDirection = false;
        ToTheRight = true;
        BehindYou = true;
        rb.AddForce(-(float)250, 0, 0);
        rb.AddForce(0, 0, -(float)250);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x >= player.transform.position.x) 
        {
            if (!ToTheRight)
            {
                rb.AddForce(-(float)500, 0, 0);
                Debug.Log("ADD FORCE LEFT");
            }

            ToTheRight = true;
          //  Debug.Log(ToTheRight);
        }
        else if (transform.position.x < player.transform.position.x)
        {
            if (ToTheRight)
            {
                rb.AddForce(+(float)500, 0, 0);
                Debug.Log("ADD FORCE RIGHT");
            }

            ToTheRight = false;
        }

        if (transform.position.z >= player.transform.position.z)
        {
            if (!BehindYou)
            {
                rb.AddForce(0, 0, -(float)500);
                Debug.Log("ADD FORCE BACKWARDS");
            }

            BehindYou = true;
            //  Debug.Log(ToTheRight);
        }
        else if (transform.position.x < player.transform.position.x)
        {
            if (BehindYou)
            {
                rb.AddForce(0, 0, +(float)500);
                Debug.Log("ADD FORCE FORWARDS");
            }

            BehindYou = false;
        }



    }
}
