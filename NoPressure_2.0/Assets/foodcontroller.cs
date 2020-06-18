using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodcontroller : MonoBehaviour
{
    private Transform tf;
    public int counter;
    public GameObject food;
    int proceduration;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        tf = food.GetComponent<Transform>();
        counter = 0;
        proceduration = 0;
    }

    // Update is called once per frame
    void Update()
    {
        food.SetActive(true);
        counter++;
        if (counter > 150)
        {
            Instantiate(food);
            tf.position = new Vector3(Random.Range(0, 60), Random.Range(0, 60), Random.Range(0, 60));
            counter = 0;
            tf.localScale = new Vector3(player.transform.localScale.x + 1, player.transform.localScale.y + 1, player.transform.localScale.z + 1);
        }
        if (proceduration < 20)
        {
            Instantiate(food);
            tf.position = new Vector3(Random.Range(0, 60), Random.Range(0, 60), Random.Range(0, 60));
            proceduration++;
            tf.localScale = new Vector3(player.transform.localScale.x + 1, player.transform.localScale.y + 1, player.transform.localScale.z + 1);
        }
    }
}
