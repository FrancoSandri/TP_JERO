using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed;
    public bool toRight;
    public GameObject CubeIzq;
    public GameObject CubeDer;
    public GameObject CubeObsIzq;



    // Start is called before the first frame update
    void Start()
    {
        toRight = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (toRight)
        {
            CubeObsIzq.transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            CubeObsIzq.transform.position -= new Vector3(speed, 0, 0);
        }

        if (CubeObsIzq.transform.position.x > CubeDer.transform.position.x - 0.1f)
        {
            toRight = false;
        }
        if (CubeObsIzq.transform.position.x < CubeIzq.transform.position.x + 0.1f)
        {
            toRight = true;
        }
    }
}
