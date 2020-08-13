using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodMushroomBulet : MonoBehaviour
{
    public EnergyBarController EnergyBar;

    void Start()
    {
        //Destroy(this.gameObject, 4);
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("..............");
        if (other.gameObject.tag == "Player")
        {
            if (EnergyBar)
            {
                EnergyBar.onTakeDamage(8);
            }
        }
        Destroy(this.gameObject);
    }
}
