﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLeft3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("e"))
		{
			Debug.Log("Tecla e detected");
			SceneManager.LoadScene("MeteoScene");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		//freeMountain.mainTexture = color;
		Debug.Log("Tecla e detected");
		SceneManager.LoadScene("MeteoScene");
	}
}
