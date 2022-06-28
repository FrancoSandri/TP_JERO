using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstantiator : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public GameObject bulletPrefab4;
    public GameObject bulletPrefab5;
    public float rateOfFire;
    float fireRateDelta;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            Fire();
            fireRateDelta = rateOfFire;
        }
    }

    public void Fire()
    {
        GameObject clon;
        GameObject clon1;
        GameObject clon2;
        GameObject clon3;
        GameObject clon4;
        GameObject clon5;
        clon = Instantiate(bulletPrefab);
        clon1 = Instantiate(bulletPrefab1);
        clon2 = Instantiate(bulletPrefab2);
        clon3 = Instantiate(bulletPrefab3);
        clon4 = Instantiate(bulletPrefab4);
        clon5 = Instantiate(bulletPrefab5);
        Destroy(clon, 6);
        Destroy(clon1, 7);
        Destroy(clon2, 6);
        Destroy(clon3, 9);
        Destroy(clon4, 6);
        Destroy(clon5, 7);
    }
}
