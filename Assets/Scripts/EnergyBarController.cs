using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class EnergyBarController : MonoBehaviour
{
    public Image EnergyBar;
    public Text EnergyBarObject;
    //public string EnergyBarText;
    public float MaxEnergy;
    public float Energy;

    private void Start()
    {
        EnergyBarShow();
    }
    public void onTakeDamage(int damage)
    {
        Energy = Energy - damage;
        EnergyBarShow();

        if (Energy<=1)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void EnergyBarShow()
    {
        EnergyBar.fillAmount = Energy / MaxEnergy;
        //EnergyBar.GetComponentInChildren<Text>().text = "Energy:   " + Energy + "/" + MaxEnergy;
        EnergyBarObject.text = "Energy:      " + Energy + "/" + MaxEnergy;


    }
}
