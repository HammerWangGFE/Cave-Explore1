using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public EnergyBarController EnergyBar;
    //private void OnCollisionEnter(Collision other)

    private void OnTriggerEnter(Collider other)
    {
        print("happened?");
        if (other.gameObject.tag == "GaintAnts")
        {
            if (EnergyBar)
            {
                EnergyBar.onTakeDamage(8);
                print(other.gameObject.tag);
            }
        }
    }
    
}
