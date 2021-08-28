using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonGreen : MonoBehaviour
{
	[SerializeField]
	public InputField inputField;
	public GameObject keypad;
	public bool openDoor = false;

	public void Clicky()
	{
        if (inputField.text.Equals("5712"))
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
