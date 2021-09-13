using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMeteoLeft3 : MonoBehaviour {

	public Material freeMountain;
	public Texture color;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("e"))
		{
			freeMountain.mainTexture = color;
			//Debug.Log("Tecla e detected");
			//SceneManager.LoadScene("test");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		//freeMountain.mainTexture = color;
		Debug.Log("Tecla e detected");
		SceneManager.LoadScene("test");
	}
}
