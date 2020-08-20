using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //=================================================
    //Game controller define the game finished or not
    //every time one GaintAnts dead, gaintAntsNumber++
    //=================================================

    public int gaintAntsNumber;
    public bool gameOver = false;

    private void Start()
    {
        gaintAntsNumber = 0;
    }
    public void GaintAntsDead()
    {
        gaintAntsNumber++;
        print(gaintAntsNumber);
        if (gaintAntsNumber == 3)
        {
            gameOver = true;
        }
    }
}
