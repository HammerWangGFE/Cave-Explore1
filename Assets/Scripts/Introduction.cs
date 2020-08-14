using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//=====================================================
//this script is in Introduction gameobject(empty one)
//it showed text message in an order: welcome 2sec, move 1sec, jump 1sec , shoot 1sec
//it allowed the door open and animi and disabled 5 secs
//the test message in on Quest test under image under Canvas
//doing this due to I don't know how to do it by triggersettext.
//may be about bug move and energy message
//=====================================================
public class Introduction : MonoBehaviour
{
	public Text questTextObject;
	public GameObject door2Object;
	public GameObject door3Object;
	public string questText;
	public float waitTime;
	public float displayTime;
	public bool onceOnly =true;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag =="Player")
		{
			StartCoroutine(WaitTimer(other));
		}
		
	}

	IEnumerator WaitTimer(Collider other)
	{
		if (other.tag == "Player" && onceOnly)
		{
			//enable door2 animations
			door2Object.SetActive(true);
			onceOnly = false;

			//=====================================================
			// current the display total time is 8 secs.
			// add more details or bool to test whether will display another message or not.
			//=====================================================
			questTextObject.gameObject.transform.parent.gameObject.SetActive(true);
			//welcome
			questText = "Welcome to 2100";
			questTextObject.text = questText;
			yield return new WaitForSeconds(2);
			//move
			questText = "[WSAD]Can you move?";
			questTextObject.text = questText;
			yield return new WaitForSeconds(2);
			//shoot
			questText = "[Mouse Left Click]Try Shoot.";
			questTextObject.text = questText;
			yield return new WaitForSeconds(2);
			//jump
			questText = "[Space]Jump?";
			questTextObject.text = questText;
			yield return new WaitForSeconds(2);

			//unabled door2 animations by destroy it. so it will not appear again.
			Destroy(door2Object);
			Destroy(door3Object);
		}


		questTextObject.text = "";
		questTextObject.gameObject.transform.parent.gameObject.SetActive(false);
	}
}