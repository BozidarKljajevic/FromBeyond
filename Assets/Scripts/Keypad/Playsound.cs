using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Playsound : MonoBehaviour 

{
	[SerializeField]
	public InputField inputField;

	public void Clicky (){
		GetComponent<AudioSource>().Play();
		inputField.text += "1";

	}
}
