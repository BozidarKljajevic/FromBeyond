﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
	[SerializeField]
	public InputField inputField;

	public void Clicky()
	{
		GetComponent<AudioSource>().Play();
		inputField.text += "2";

	}
}
