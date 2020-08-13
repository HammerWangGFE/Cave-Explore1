using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarController : MonoBehaviour
{
    public Image EnergyBar;
    public float Energy;
    public float startEnergy;

    public void onTakeDamage(int damage)
    {
        Energy = Energy - damage;
        EnergyBar.fillAmount = Energy / startEnergy;
    }
}
