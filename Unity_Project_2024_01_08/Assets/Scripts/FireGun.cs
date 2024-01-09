using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;

    public float fireRate = 1.0f;
    private float nextFireTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
        }
    }
}
