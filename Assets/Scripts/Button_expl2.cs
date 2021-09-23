using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_expl2 : MonoBehaviour
{
	public GameObject Mapa;
	public GameObject Tabela;
	public Material freeMountain;
    public Texture batimetria;
	public Button Obotao1;
	public Button Obotao2;
	public Button Obotao3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
		{
			Tabela.SetActive(false);
			Mapa.SetActive(true);
			freeMountain.mainTexture = batimetria;
			Obotao1.GetComponent<Image>().color = Color.white;
			Obotao2.GetComponent<Image>().color = Color.green;
			Obotao3.GetComponent<Image>().color = Color.white;
		}
	}

    void OnTriggerEnter(Collider other)
    {
		Tabela.SetActive(false);
		Mapa.SetActive(true);
		freeMountain.mainTexture = batimetria;
		Obotao1.GetComponent<Image>().color = Color.white;
		Obotao2.GetComponent<Image>().color = Color.green;
		Obotao3.GetComponent<Image>().color = Color.white;
	}
}
