using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{

    public GameObject camera2;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        camera2.transform.position = new Vector3(-16.35f, 1.89f, -21.8f);
        player2.transform.position = new Vector3(-7.8f, -2.33f, 0.01433503f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
