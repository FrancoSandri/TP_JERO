﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    public float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, -rotationspeed, 0);
    }
}
