using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGaintAnts1 : MonoBehaviour
{
    public GameObject gaintAnts;
    private bool onlyOnce = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            if (onlyOnce)
            {
                gaintAnts.GetComponent<IsMoving>().isMoving = true;
                onlyOnce = false;
            }
        }
        
        
        
    }
}
