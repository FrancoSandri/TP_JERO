using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public bool instantiator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        instantiator = true;
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator ExampleCoroutine()
    {
        while (instantiator)
        {
            GameObject clon;
            clon= Instantiate(objectToClone);
            Destroy(clon, 20);
            yield return new WaitForSeconds(2.5f);

        }
    }

    
}
