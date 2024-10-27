using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Level1 : MonoBehaviour
{

    public GameObject camera1;
    public GameObject player;
    public Transform nextlevel;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Camera.main.orthographicSize = 3;
        camera1.transform.position = new Vector3(1.92f, 1.61f, -21.8f);
        player.transform.position = new Vector3(0.07376355f, -1.71f, 0.05206658f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
