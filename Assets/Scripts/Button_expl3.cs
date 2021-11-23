using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_expl3 : MonoBehaviour
{
	public GameObject Mapa;
	public GameObject Tabela;
	public Material freeMountain;
    public Texture topo;
	public Button Obotao1;
	public Button Obotao2;
	public Button Obotao3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("e"))
		{
			Tabela.SetActive(false);
			Mapa.SetActive(true);
			freeMountain.mainTexture = topo;
			Obotao1.GetComponent<Image>().color = Color.white;
			Obotao2.GetComponent<Image>().color = Color.white;
			Obotao3.GetComponent<Image>().color = Color.green;
		}
	}

    void OnTriggerEnter(Collider other)
    {
		Tabela.SetActive(false);
		Mapa.SetActive(true);
		freeMountain.mainTexture = topo;
		Obotao1.GetComponent<Image>().color = Color.white;
		Obotao2.GetComponent<Image>().color = Color.white;
		Obotao3.GetComponent<Image>().color = Color.green;
	}
}
