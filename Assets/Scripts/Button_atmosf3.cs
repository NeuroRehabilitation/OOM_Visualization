using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_atmosf3 : MonoBehaviour
{
    public Material freeMountain;
    public Texture satelite;
	public Button Obotao1;
	public Button Obotao2;
	public Button Obotao3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("e"))
		{
			freeMountain.mainTexture = satelite;
			Obotao1.GetComponent<Image>().color = Color.white;
			Obotao2.GetComponent<Image>().color = Color.white;
			Obotao3.GetComponent<Image>().color = Color.green;
		}
	}

    void OnTriggerEnter(Collider other)
    {
        freeMountain.mainTexture = satelite;
		Obotao1.GetComponent<Image>().color = Color.white;
		Obotao2.GetComponent<Image>().color = Color.white;
		Obotao3.GetComponent<Image>().color = Color.green;
	}
}
