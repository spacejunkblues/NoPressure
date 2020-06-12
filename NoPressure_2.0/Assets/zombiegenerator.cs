using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zombiegenerator : MonoBehaviour
{
    public GameObject Zombie;
    public int counter;
    public Random rnd;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("scene", LoadSceneMode.Additive);
    }
}
