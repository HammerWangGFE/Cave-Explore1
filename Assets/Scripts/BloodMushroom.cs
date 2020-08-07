using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodMushroom : MonoBehaviour
{
    //health == current health.
    public int maxHealth = 21;
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
    }

    public void ChangeColor(int damageToTake)
    {
        if (health > 0)
        {
            health = health - damageToTake;
            float temp = (float)(health * 1.0 / maxHealth);
            myRender.material.color = Color.Lerp(whiteColor, orginialColor, temp);
            
        }
        else
        {
            this.transform.localScale = new Vector3(0.1f,2.8f,0.1f);
            this.transform.position += new Vector3(0f,-1.8f,0f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        print("Begin to shoot Player.");
    }
}
