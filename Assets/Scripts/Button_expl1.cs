using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_expl1 : MonoBehaviour
{
	public GameObject Mapa;
	public GameObject Tabela;
	public Material freeMountain;
    public Texture tabela;
	public Button Obotao1;
	public Button Obotao2;
	public Button Obotao3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("q"))
		{
			Mapa.SetActive(false);
			Tabela.SetActive(true);
			Obotao1.GetComponent<Image>().color = Color.green;
			Obotao2.GetComponent<Image>().color = Color.white;
			Obotao3.GetComponent<Image>().color = Color.white;

		}
	}

    void OnTriggerEnter(Collider other)
    {
		Mapa.SetActive(false);
		Tabela.SetActive(true);
		Obotao1.GetComponent<Image>().color = Color.green;
		Obotao2.GetComponent<Image>().color = Color.white;
		Obotao3.GetComponent<Image>().color = Color.white;
	}
}
