using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft3 : MonoBehaviour {

	public static bool bt3onflag;

	// Use this for initialization
	void Start () {
		bt3onflag = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("e"))
		{
			if (bt3onflag == false)
            {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(1, 1, 1);
				cube.transform.localScale = new Vector3(1.9f, 0.9f, 1);
				Material m_material = cube.GetComponent<Renderer>().material;
				m_material.color = Color.yellow;
				bt3onflag = true;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		//freeMountain.mainTexture = color;
		if (bt3onflag == false)
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(1, 1, 1);
			cube.transform.localScale = new Vector3(1.9f, 0.9f, 1);
			Material m_material = cube.GetComponent<Renderer>().material;
			m_material.color = Color.yellow;
			bt3onflag = true;
		}
	}
}
