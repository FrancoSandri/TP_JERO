using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basemovement : MonoBehaviour
{
    public float speed;
    public GameObject CubeIzq;
    public GameObject CubeDer;
    public bool toRight;

    public void Start()
    {
        
        
    }

    public void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > CubeDer.transform.position.x - 0.1f)
        {
            toRight = false;
        }
        if (transform.position.x < CubeIzq.transform.position.x + 0.1f)
        {
            toRight = true;
        }
    }
}
