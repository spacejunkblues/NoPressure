using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Declaring references
    public GameObject Bullet;
    public GameObject Scenery1;
    public GameObject Scenery2;
    public GameObject Scenery3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      void OnCollisionEnter(Collision collisioninfo)
    {

       Destroy(Bullet);
       
       
        

    }
    
    
    }
}
