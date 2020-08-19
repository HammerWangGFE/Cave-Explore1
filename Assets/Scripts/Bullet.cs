using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    void Start()
    {
        Destroy(this.gameObject,4);
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("..............");
        if (other.gameObject.tag =="GaintAnts")
        {
            other.gameObject.GetComponent<GaintAnts>().ChangeColor(4);
            //print("Hello");
        }else if (other.gameObject.tag == "BloodMushroom")
        {
            other.gameObject.GetComponent<BloodMushroom>().ChangeColor(4);
        }

        Destroy(this.gameObject);
    }
}
