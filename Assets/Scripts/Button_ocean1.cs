using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_ocean1 : MonoBehaviour
{
    public Material freeMountain;
    public Texture correntes;
	public Button Obotao1;
	public Button Obotao2;
	public Button Obotao3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("q"))
		{
			freeMountain.mainTexture = correntes;
			Obotao1.GetComponent<Image>().color = Color.green;
			Obotao2.GetComponent<Image>().color = Color.white;
			Obotao3.GetComponent<Image>().color = Color.white;
		}
	}

    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = correntes;
		Obotao1.GetComponent<Image>().color = Color.green;
		Obotao2.GetComponent<Image>().color = Color.white;
		Obotao3.GetComponent<Image>().color = Color.white;
	}
}
