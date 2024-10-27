using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boo : MonoBehaviour
{
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        image.SetActive(true);
    }
}
