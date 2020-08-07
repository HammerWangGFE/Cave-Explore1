﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaintAnts : MonoBehaviour
{
    //health == current health.
    public int maxHealth = 30;
    public int health;

    //dead is while white
    public Color whiteColor;
    private Color orginialColor;
    Renderer myRender;

    // Start is called before the first frame update
    void Start()
    {
        myRender = GetComponent<Renderer>();
        orginialColor = myRender.material.color;

        health = maxHealth;

        //foreach (Transform child in this.transform)
        //{
        //    Debug.Log(child.name);
        //}
    }

    // Update is called once per frame
    public void ChangeColor(int damageToTake)
    {
        if (health > 0)
        {
            health = health - damageToTake;
            float temp = (float)(health * 1.0 / maxHealth);
            //print(temp);
            myRender.material.color = Color.Lerp(whiteColor, orginialColor, temp);
        }
        else
        {
            foreach (Transform child in this.transform)
            {
                child.gameObject.GetComponent<Renderer>().material.color = whiteColor;
            }
        }
        
    }
}
