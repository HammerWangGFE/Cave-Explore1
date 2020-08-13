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

    public GameObject firePoint;
    public GameObject bulletPrefab;
    public float launchPower = 2;
    public bool canShoot;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        myRender = GetComponent<Renderer>();
        orginialColor = myRender.material.color;

        health = maxHealth;
        //default is false , true for testing
        //only one BloodMushroombullet in the whole scene. when this BloodMushroombullet destroied and fire another one.
        canShoot = false;
    }

    public void ChangeColor(int damageToTake)
    {
        if (health > 0)
        {
            health = health - damageToTake;
            float temp = (float)(health * 1.0 / maxHealth);
            print("Bloodmushroom:" + temp);
            myRender.material.color = Color.Lerp(whiteColor, orginialColor, temp);
            
        }
        else
        {
            if (isAlive)
            {
                this.transform.localScale = new Vector3(0.3f, 1.5f, 0.3f);
                this.transform.position += new Vector3(0f, -1f, 0f);
                isAlive = false;
            }
            
        }

    }


    void Update()
    {
        //if (canShoot)
        //{
        //    Shoot();
        //    canShoot = false;
        //}
    }

    private void Shoot()
    {
        Vector3 PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        Debug.Log(PlayerPosition);
        Vector3 heading = transform.position - PlayerPosition;
        Debug.Log(heading);

        //shoot aim player's location
        GameObject GO = Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity) as GameObject;
        GO.GetComponent<Rigidbody>().AddForce(heading * launchPower, ForceMode.Impulse);
    }
}
