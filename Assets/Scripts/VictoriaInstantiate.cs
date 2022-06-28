using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaInstantiate : MonoBehaviour
{
    public GameObject objectToClone;
    

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 100; i++)
        {
            GameObject clon;
            clon = Instantiate(objectToClone);
            Destroy(clon, 8);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
