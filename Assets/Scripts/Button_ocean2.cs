using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_ocean2 : MonoBehaviour
{
    public Material freeMountain;
    public Texture temperatura;
	public Button Obotao1;
	public Button Obotao2;
	public Button Obotao3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
		{
			freeMountain.mainTexture = temperatura;
			Obotao1.GetComponent<Image>().color = Color.white;
			Obotao2.GetComponent<Image>().color = Color.green;
			Obotao3.GetComponent<Image>().color = Color.white;
		}
	}

    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = temperatura;
		Obotao1.GetComponent<Image>().color = Color.white;
		Obotao2.GetComponent<Image>().color = Color.green;
		Obotao3.GetComponent<Image>().color = Color.white;
	}
}
