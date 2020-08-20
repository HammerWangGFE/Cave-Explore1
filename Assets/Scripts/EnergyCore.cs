using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnergyCore : MonoBehaviour
{
    public EnergyBarController EnergyBar;
	public GameObject GameController;
	private bool onlyOnce = true;


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"&&onlyOnce)
		{
			//give 15 Energy to EnergyBar
			EnergyBar.onTakeDamage(-15);
			onlyOnce = false;
			if (EnergyBar.Energy > EnergyBar.MaxEnergy)
			{
				EnergyBar.MaxEnergy = EnergyBar.Energy;
				EnergyBar.EnergyBarShow();
			}

			if (GameController.GetComponent<GameController>().gameOver)
			{
				SceneManager.LoadScene(2);
			}
		}

	}
}
