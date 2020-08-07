using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glove : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject bulletPrefab;
    public float launchPower = 2;

    public float refireRate;
    private float timePassed;
    private bool canShoot;

    private void Start()
    {
        canShoot = true;
    }

    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (canShoot))
        {
            Shoot();
            canShoot = false;
            timePassed = 0.0f;
        }

        timePassed += Time.deltaTime;

        if (timePassed >= refireRate)
        {
            canShoot = true;
        }
    }

    private void Shoot()
    {
        GameObject GO = Instantiate(bulletPrefab,firePoint.transform.position, Quaternion.identity) as GameObject;
        GO.GetComponent<Rigidbody>().AddForce(firePoint.transform.forward* launchPower, ForceMode.Impulse);
    }
}
