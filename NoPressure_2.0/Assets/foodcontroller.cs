using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodcontroller : MonoBehaviour
{
    private Transform tf;
    public int counter;
    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        tf = food.GetComponent<Transform>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        food.SetActive(true);
        counter++;
        if (counter > 200)
        {
            Instantiate(food);
            tf.position = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
            counter = 0;
        }
    }
}
