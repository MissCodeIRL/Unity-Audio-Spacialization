using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public GameObject player;
    public Vector3 firstPosition;
    public Vector3 secondPosition;
    public Vector3 thirdPosition;
    public Vector3 fourthPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("First Person Controller");
        firstPosition = new Vector3(0,2,-5);
        secondPosition = new Vector3(4,2,9);
        thirdPosition = new Vector3(-35, -20, 0);
        fourthPosition = new Vector3(-45, -20, 20);   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            transform.position = firstPosition;
        }
        if (Input.GetKeyDown("2"))
        {
            transform.position = secondPosition;
        }
        if (Input.GetKeyDown("3"))
        {
            transform.position = thirdPosition;
        }
        if (Input.GetKeyDown("4"))
        {
            transform.position = fourthPosition;
        }
    }
}
