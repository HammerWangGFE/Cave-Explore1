using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glove : MonoBehaviour
{
    //shoot evergy bullet, take -1 from Energy Bar;
    //Can't shoot last bulle
    public EnergyBarController EnergyBar;

    public GameObject firePoint;
    public GameObject bulletPrefab;
    public float launchPower = 2;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (EnergyBar.Energy > 1))
        {

            Shoot();

            if (EnergyBar)
            {
                EnergyBar.onTakeDamage(1);
                print(EnergyBar.Energy);
            }

        }
    }

    private void Shoot()
    {
        GameObject GO = Instantiate(bulletPrefab,firePoint.transform.position, Quaternion.identity) as GameObject;
        GO.GetComponent<Rigidbody>().AddForce(firePoint.transform.forward* launchPower, ForceMode.Impulse);
    }
}
