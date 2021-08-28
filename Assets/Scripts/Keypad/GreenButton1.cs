using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenButton1 : MonoBehaviour
{
	[SerializeField]
	public InputField inputField;
	public GameObject keypad;
	public bool openDoor = false;

	public void Clicky()
	{
		if (inputField.text.Equals("0486"))
		{
			GetComponent<AudioSource>().Play();
			openDoor = true;
			Debug.Log(openDoor + "Ovo je posle dugmeta");
			keypad.SetActive(false);
			Time.timeScale = 1f;
		}
		else
		{
			GetComponent<AudioSource>().Play();
			inputField.text = "";
		}



	}
}
