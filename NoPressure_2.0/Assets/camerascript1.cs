using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript1 : MonoBehaviour
{
    public GameObject player;
    private Transform playertf;
    public Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        playertf = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position = new Vector3(playertf.position.x, playertf.position.y + 2, playertf.position.z - 6);
    }
}
