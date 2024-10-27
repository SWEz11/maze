using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    public GameObject camera3;

    void Start()
    {
        camera3.transform.position = new Vector3(-45.65f, 7.58f, -21.8f);
        UnityEngine.Camera.main.orthographicSize = 6.43f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
